using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.AssessmentContext;
using SIS.Shared.Exceptions;
using SIS.Shared.V1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Services
{
    public interface ILecturerAssessmentService
    {
        Task<List<AssessmentLecturerGetDTO>> GetLecturersForRegisteredCoursesAsync(string studentId);
        Task<AssessmentGetDTO> GetAssessmentAsync(string studentId, string courseCode);
        Task SaveAssessmentAsync(AssessmentAddDTO assessment);
    }

    public class LecturerAssessmentService : ILecturerAssessmentService
    {
        private readonly IAssessmentResponseValueRepository _assessmentResponseValueRepository;
        private readonly IAssessmentQuestionRepository _assessmentQuestionRepository;
        private readonly IAssessmentCommentRepository _assessmentCommentRepository;
        private readonly IAssessmentResponseRepository _assessmentResponseRepository;
        private readonly ILecturerAssessmentRepository _lecturerAssessmentRepository;
        private readonly ILecturerRepository _lecturerRepository;
        private readonly IAssessmentStudentLogRepository _assessmentStudentLogRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly FunctionsService _functionsService;
        private readonly IMapper _mapper;

        public LecturerAssessmentService(IAssessmentResponseValueRepository assessmentResponseValueRepository, IAssessmentQuestionRepository assessmentQuestionRepository, FunctionsService functionsService, IStudentRepository studentRepository, IMapper mapper, IAssessmentResponseRepository assessmentResponseRepository, IAssessmentCommentRepository assessmentCommentRepository, ILecturerAssessmentRepository lecturerAssessmentRepository, IAssessmentStudentLogRepository assessmentStudentLogRepository, ILecturerRepository lecturerRepository)
        {
            _assessmentResponseValueRepository = assessmentResponseValueRepository;
            _assessmentQuestionRepository = assessmentQuestionRepository;
            _functionsService = functionsService;
            _studentRepository = studentRepository;
            _mapper = mapper;
            _assessmentResponseRepository = assessmentResponseRepository;
            _assessmentCommentRepository = assessmentCommentRepository;
            _lecturerAssessmentRepository = lecturerAssessmentRepository;
            _assessmentStudentLogRepository = assessmentStudentLogRepository;
            _lecturerRepository = lecturerRepository;
        }

        public async Task<AssessmentGetDTO> GetAssessmentAsync(string studentId, string courseCode)
        {
            int setId = await _functionsService.GetAssessmentQuestionSetId(studentId, courseCode);
            var choices = await _assessmentResponseValueRepository.Query().Where(a => a.Setid == setId)
                   .Select(a => new AssessmentQuestionChoiceGetDTO { Label = a.Label, Value = a.Value, SetId = a.Setid, ResponseValueId = a.Responsevalueid })
                   .ToListAsync();

            var choiceQuestions = await _assessmentQuestionRepository
                    .Query()
                    .Include(x => x.Category)
                    .Where(q => q.Iscomment == false && q.Setid == setId)
                    .Select(a => new AssessmentQuestionGetDTO
                    {
                        Quiz = a.Question1,
                        Number = a.Qno,
                        QuestionId = a.Qid,
                        SetId = a.Setid,
                        IsCompulsory = true,
                        CategoryId = a.Categoryid ?? -1,
                        CategoryName = a.Category.Category1 ?? "",
                        IsCommentQuestion = a.Iscomment ?? false,
                        Choices = choices
                    }).ToListAsync();



            var commentQuestions = await _assessmentQuestionRepository
                    .Query()
                    .Where(q => q.Iscomment == true && q.Setid == setId)
                    .Select(a => new AssessmentQuestionGetDTO
                    {
                        Quiz = a.Question1,
                        Number = a.Qno,
                        QuestionId = a.Qid,
                        SetId = a.Setid,
                        IsCompulsory = false,
                        CategoryId = a.Categoryid ?? -1,
                        CategoryName = a.Category.Category1 ?? "",
                        IsCommentQuestion = a.Iscomment ?? false,
                        Choices = choices
                    }).ToListAsync();

            List<AssessmentQuestionGetDTO> allQuestions = new List<AssessmentQuestionGetDTO>();
            allQuestions.AddRange(choiceQuestions);
            allQuestions.AddRange(commentQuestions);

            allQuestions.Sort((a, b) => a.Number.CompareTo(b.Number));

            var assessment = new AssessmentGetDTO()
            {
                SetId = setId,
                Questions = allQuestions
            };

            return assessment;
        }

        public async Task<List<AssessmentLecturerGetDTO>> GetLecturersForRegisteredCoursesAsync(string studentId)
        {

            var tblPreAssessmentChecks = (await _functionsService.PreAssessmentChecksAsync(studentId)).FirstOrDefault();

            string errorMessage = tblPreAssessmentChecks.RESULTMESSAGE == null ? "" : tblPreAssessmentChecks.RESULTMESSAGE;

            if (!string.IsNullOrEmpty(errorMessage))
            {
                throw new CustomException(errorMessage);
            }

            var assessmentParams = (await _functionsService.GetAssessmentParametersAsync()).FirstOrDefault();
            int assessmentAcadYear = assessmentParams.ACADYEAR;
            int assessmentSem = assessmentParams.SEM;
            var studentSemesterProgramme = await _functionsService.GetStudentSemesterProgramme(studentId, assessmentAcadYear, assessmentSem);

            if (studentSemesterProgramme == null)
            {
                throw new StudentNotFoundException();
            }

            int programmeStreamId = studentSemesterProgramme.PROGRAMMESTREAMID;
            int currentAcadLevelId = studentSemesterProgramme.ACADLEVELID;
            int optionId = studentSemesterProgramme.OPTIONID;
            var entities = await _studentRepository.GetLecturersforStudentRegisteredCourses(studentId, programmeStreamId, assessmentAcadYear, assessmentSem, optionId, currentAcadLevelId);

            var dtos = entities.Select(x =>
            {
                var dto = _mapper.Map<AssessmentLecturerGetDTO>(x);
                dto.IsAssessed = AlreadySubmitted(dto.AcadYear, dto.Sem, dto.CourseCode, studentId);
                return dto;
            }).ToList();

            return _mapper.Map<List<AssessmentLecturerGetDTO>>(dtos);
        }

        public async Task SaveAssessmentAsync(AssessmentAddDTO assessment)
        {
            var alreadySubmitted = AlreadySubmitted(assessment.AcadYear, assessment.Sem, assessment.CourseCode, assessment.StudentId, assessment.SetId);
            if (alreadySubmitted)
            {
                throw new CustomException($"Assessment has already been completed for {assessment.CourseCode}.");
            }


            var unansweredQuestions = assessment.Answers.Where(x => x.IsCompulsory && x.Answer == null).ToList();
            if (unansweredQuestions.Count > 0)
            {
                string[] unanswerQuestionsArr = unansweredQuestions.Select(x => x.QuestionId.ToString()).ToArray();
                string unanswerQuestionsSubstring = string.Join(", ", unansweredQuestions);
                throw new CustomException($"Please answer all the following compulsory questions before submitting.\r\n{unanswerQuestionsSubstring}.");
            }


            var lecturer = await _lecturerRepository.Query().FirstOrDefaultAsync(x => x.Lecturerid == assessment.LecturerId);
            if(lecturer == null)
            {
                throw new CustomException("Lecturer does not exist.");
            }

            string staffId = lecturer.Staffid;

            var assessmentResult = await _lecturerAssessmentRepository.AddLecturerAssessmentAsync(assessment.SetId, assessment.AcadYear, assessment.Sem, assessment.CourseCode, staffId);

            var choices = assessment.Answers.Where(x => x.IsCommentQuestion == false).ToList();
            var comments = assessment.Answers.Where(x => x.IsCommentQuestion == true).ToList();
            foreach (AssessmentAnswerDTO answer in choices)
            {
                if (answer.Answer != null)
                {
                    var responseValueId = int.Parse(answer.Answer.ToString());
                    await _assessmentResponseRepository.AddAssessmentResponseAsync(assessmentResult.ASSESSMENTID, answer.QuestionId, responseValueId);
                }
            }

            foreach (AssessmentAnswerDTO answer in comments)
            {
                if (answer.Answer != null)
                {
                    await _assessmentCommentRepository.AddAssessmentCommentAsync(assessmentResult.ASSESSMENTID, answer.QuestionId, answer.Answer?.ToString());
                }
            }

            var log = new Studentlog
            {
                Setid = assessment.SetId,
                Acadyear = assessment.AcadYear,
                Sem = assessment.Sem,
                Coursecode = assessment.CourseCode,
                Studentid = assessment.StudentId,
                Staffid = staffId
            };

            await _assessmentStudentLogRepository.AddStudentAssessmentLog(log);
        }

        private bool AlreadySubmitted(int AcadYear, int Sem, string CourseCode, string StudentId, int SetId = 0)
        {
            return _assessmentStudentLogRepository.Query().Any(s => s.Studentid == StudentId && s.Acadyear == AcadYear && s.Sem == Sem && s.Coursecode == CourseCode && (SetId > 0 ? s.Setid == SetId : true));

        }
    }
}

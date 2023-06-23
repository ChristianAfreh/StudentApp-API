using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Exceptions;
using SIS.Shared.Helpers;
using SIS.Shared.Settings;
using SIS.Shared.V1.Repositories;

namespace SIS.Shared.V1.Services
{
    public interface IAcademicRecordService
    {
        Task<AcademicRecordGetDTO> GetSemesterResultsAsync(string studentId, int acadYear, int sem);
        Task<RegistrationParametersGetDTO> GetRegistrationParametersAsync(string studentId, string username, string app, int appVersion);
        Task<List<RegistrationCourseGetDTO>> GetRegistrationCoursesAsync(string studentId);
        Task<List<RegisteredCourseGetDTO>> SaveRegistrationCoursesOnlineAsync(string studentId, string username, string app, int appVersion, List<RegistrationCourseAddDTO> courses);
        Task SyncAcademicRecordsAsync(string username, string studentId, string app = "AIM", int appVersion = -1);
    }

    public class AcademicRecordService : IAcademicRecordService
    {
        private readonly IAcademicRecordRepository _academicRecordRepository;
        private readonly IAcademicRecordOnlineRepository _academicRecordOnlineRepository;
        private readonly IStudentProgrammeRepository _studentProgrammeRepository;
        private readonly IStudentSemesterRepository _studentSemesterRepository;
        private readonly IViewCourseRepository _viewCourseRepository;
        private readonly FunctionsService _functionsService;
        private readonly RegistrationSettings _registrationSettings;
        private readonly IMapper _mapper;

        public AcademicRecordService(IAcademicRecordRepository academicRecordRepository, IMapper mapper, IStudentProgrammeRepository studentProgrammeRepository, IOptionsMonitor<RegistrationSettings> optionsMonitor, FunctionsService functionsService, IStudentSemesterRepository studentSemesterRepository, IViewCourseRepository viewCourseRepository, IAcademicRecordOnlineRepository academicRecordOnlineRepository)
        {
            _mapper = mapper;
            _academicRecordRepository = academicRecordRepository;
            _studentProgrammeRepository = studentProgrammeRepository;
            _functionsService = functionsService;
            _studentSemesterRepository = studentSemesterRepository;
            _viewCourseRepository = viewCourseRepository;
            _academicRecordOnlineRepository = academicRecordOnlineRepository;
            _registrationSettings = optionsMonitor.CurrentValue;
        }

        public async Task<List<RegistrationCourseGetDTO>> GetRegistrationCoursesAsync(string studentId)
        {
            int programmeStreamId = _functionsService.GetStudentCurrentProgrammeStreamId(studentId);
            int currentAcadYear = _functionsService.GetDefaultProgrammeStreamAcadYear(programmeStreamId);
            int currentSem = _functionsService.GetDefaultProgrammeStreamAcadYearSem(programmeStreamId);
            var studentSemesterProgramme = await _functionsService.GetStudentSemesterProgramme(studentId, currentAcadYear, currentSem);
            int currentAcadLevelId = studentSemesterProgramme.ACADLEVELID;
            int optionId = studentSemesterProgramme.OPTIONID;

            var courses = await _viewCourseRepository.GetCoursesForRegistrationAsync(studentId, programmeStreamId, currentAcadYear, currentSem, currentAcadLevelId, optionId);
            //await _academicRecordOnlineRepository.SyncAcademicRecordsOnlineAsync(username, st)
            var registeredCourses = await _academicRecordRepository.GetSemesterRegisteredCoursesAsync(studentId, programmeStreamId, currentAcadYear, currentSem, currentAcadLevelId);


            //GetOnlineRegisteredCoursesAsync(studentId, programmeStreamId, currentAcadYear, currentSem, currentAcadLevelId); 

            if(courses.Count == 0) 
	        {
                throw new CustomException("No courses have been set up for registration. Please contact your examination officer.");
            }

            List<RegistrationCourseGetDTO> registrationCourses = courses
              .Select(R => new RegistrationCourseGetDTO
              {
                  AcadYear = currentAcadYear,
                  Sem = currentSem,
                  CourseCode = R.Coursecode.Trim(),
                  CourseName = R.Coursename.Trim(),
                  Credit = R.Credit,
                  ElectiveSetId = R.Electivesetid ?? -1,
                  CourseTypeId = R.Coursetypeid,
                  //IsPreviousTrail = R.
                  IsRegistered = registeredCourses.Any(x => x.Coursecode == R.Coursecode)
              }).ToList();

            return registrationCourses;
        }

        private async Task<string> PreRegistrationChecks(string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId, string username, string app, int appVersion)
        {
           
            var r = await _academicRecordRepository.GetPreRegistrationsChecksAsync(studentId, acadYear, sem);
            r = r ?? "";
            r = r.Trim('\n').Trim('\r');
            var message = string.Empty;
            if (!string.IsNullOrEmpty(r))
            {
                StringBuilder stringBuilder = new StringBuilder();
                string[] stringSeparators = new string[] { Environment.NewLine };
                var resultMessageArray = r.Split(stringSeparators, StringSplitOptions.None);
                foreach (var resultMessage in resultMessageArray)
                {
                    if (!string.IsNullOrEmpty(resultMessage) || resultMessage != "")
                    {
                        stringBuilder.Append(resultMessage);
                    }
                }

                message = stringBuilder.ToString();
            }
            else
            {
                 await _academicRecordOnlineRepository.SyncAcademicRecordsOnlineAsync(username, studentId, programmeStreamId, acadYear, sem, acadLevelId, app, appVersion);

            }
            return message;
        }



        public async Task<RegistrationParametersGetDTO> GetRegistrationParametersAsync(string studentId, string username, string app, int appVersion)
        {
            int programmeStreamId = _functionsService.GetStudentCurrentProgrammeStreamId(studentId);
            int currentAcadYear = _functionsService.GetDefaultProgrammeStreamAcadYear(programmeStreamId);
            int currentSem = _functionsService.GetDefaultProgrammeStreamAcadYearSem(programmeStreamId);
            int currentAcadLevelId = await _functionsService.GetStudentCurrentAcadLevelIdAsync(studentId, programmeStreamId, currentAcadYear, currentSem);
            
            string errorMessage = await PreRegistrationChecks(studentId, programmeStreamId, currentAcadYear, currentSem, currentAcadLevelId, username, app, appVersion);


            RegistrationParametersGetDTO registrationParameters;
            if (string.IsNullOrEmpty(errorMessage))
            {
                //int noOfSemTrails = (await _functionsService.GetSemesterOutstandingTrails(studentId, programmeStreamId, currentAcadYear, currentSem)).Count;
                //int noOfAllTrails = (await _functionsService.GetAllOutstandingTrails(studentId, programmeStreamId, currentAcadYear, currentSem)).Count;
                registrationParameters = await GetRegistrationParameters(studentId, programmeStreamId, currentAcadYear, currentSem, currentAcadLevelId);
            }
            else
            {
                registrationParameters = new RegistrationParametersGetDTO
                {
                    MaxElectiveSet1 = 0,
                    MaxElectiveSet2 = 0,
                    MaxElectiveSet3 = 0,
                    MinElectiveSet1 = 0,
                    MinElectiveSet2 = 0,
                    MinElectiveSet3 = 0,
                    ChangeOption = false,
                    AcadYear = currentAcadYear,
                    Sem = currentSem,
                    CurrentDate = DateTime.Now,
                    FeesPaid = (decimal?)0.01,
                    IncludeOpenElectives = false,
                    IncludeTrails = false,
                    MaxSemCredits = 0,
                    MinSemCredits = 0,
                    NoOfRegisteredCourses = 0,
                    OptionId = 0,
                    OptionName = "",
                    RegistrationStartDate = DateTime.Now,
                    RegistrationEndDate = DateTime.Now,
                    RegistrationInstructionsUrl = _registrationSettings.RegistrationInstructionsUrl,
                    ErrorMessage = errorMessage,
                    Message = errorMessage,
                    CanRegister = false
                };
            }

            return registrationParameters;
        }

        private async Task<RegistrationParametersGetDTO> GetRegistrationParameters(string studentId, int programmeStreamId, int currentAcadYear, int currentSem, int currentAcadLevelId)
        {
            RegistrationParametersGetDTO registrationParameters = new RegistrationParametersGetDTO();
            var studentSemesterProgramme = await _functionsService.GetStudentSemesterProgramme(studentId, currentAcadYear, currentSem);
            int noOfRegisteredCourses = await _functionsService.GetRegisteredCourseCountAsync(studentId, programmeStreamId, currentAcadYear, currentSem);

            int optionId = studentSemesterProgramme.OPTIONID;

            List<Viewcourse> electives = await _viewCourseRepository.Query()
            .Where(a => a.Programmestreamid == programmeStreamId
                && a.Acadyear == currentAcadYear
                && a.Sem == currentSem
                && a.Acadlevelid == currentAcadLevelId
                && a.Coursetypeid == 2
                && a.Optionid == optionId)
            .ToListAsync();


            int minElectiveSet1 = 0;
            int minElectiveSet2 = 0;
            int minElectiveSet3 = 0;

            int noOfElectiveSet1 = electives.Where(a => a.Electivesetid == 1).Count();
            minElectiveSet1 = noOfElectiveSet1 > 0 ? 1 : 0;

            int noOfElectiveSet2 = electives.Where(a => a.Electivesetid == 2).Count();
            minElectiveSet2 = noOfElectiveSet2 > 0 ? 1 : 0;

            int noOfElectiveSet3 = electives.Where(a => a.Electivesetid == 3).Count();
            minElectiveSet3 = noOfElectiveSet3 > 0 ? 1 : 0;

            var CHECKPARAMETERS = await _functionsService.GetRegistrationParameters(studentId, programmeStreamId, currentAcadYear, currentSem, currentAcadLevelId, optionId);

            registrationParameters.AcadYear = currentAcadYear;
            registrationParameters.Sem = currentSem;
            registrationParameters.OptionId = optionId;
            registrationParameters.OptionName = studentSemesterProgramme.OPTIONNAME;
            registrationParameters.FeesPaid = studentSemesterProgramme.FEESPAID;
            registrationParameters.MinElectiveSet1 = CHECKPARAMETERS.MINELECTIVESET1 == 0 ? minElectiveSet1 : CHECKPARAMETERS.MINELECTIVESET1;
            registrationParameters.MinElectiveSet2 = CHECKPARAMETERS.MINELECTIVESET2 == 0 ? minElectiveSet2 : CHECKPARAMETERS.MINELECTIVESET2;
            registrationParameters.MinElectiveSet3 = CHECKPARAMETERS.MINELECTIVESET3 == 0 ? minElectiveSet3 : CHECKPARAMETERS.MINELECTIVESET3;
            registrationParameters.MaxElectiveSet1 = CHECKPARAMETERS.MAXELECTIVESET1;
            registrationParameters.MaxElectiveSet2 = CHECKPARAMETERS.MAXELECTIVESET2;
            registrationParameters.MaxElectiveSet3 = CHECKPARAMETERS.MAXELECTIVESET3;
            registrationParameters.MinSemCredits = CHECKPARAMETERS.MINSEMCREDITS;
            registrationParameters.MaxSemCredits = CHECKPARAMETERS.MAXSEMCREDITS;
            registrationParameters.RegistrationStartDate = CHECKPARAMETERS.REGISTRATIONSTARTDATE;
            registrationParameters.RegistrationEndDate = CHECKPARAMETERS.REGISTRATIONENDDATE;
            registrationParameters.IncludeOpenElectives = CHECKPARAMETERS.INCLUDEOPENELECTIVE;
            registrationParameters.IncludeTrails = currentSem == 3;
            registrationParameters.ChangeOption = CHECKPARAMETERS.CHANGEOPTION;
            registrationParameters.NoOfRegisteredCourses = noOfRegisteredCourses;
            registrationParameters.RegistrationInstructionsUrl = _registrationSettings.RegistrationInstructionsUrl;



            string customDateFormat = "dd MMMM yyyy";
            string customTimeFormat = "HH:mm";
            DateTime currentDate = _functionsService.GetServerDate();
            DateTime registrationStartDate = (DateTime)CHECKPARAMETERS.REGISTRATIONSTARTDATE;
            DateTime registrationEndDate = (DateTime)CHECKPARAMETERS.REGISTRATIONENDDATE;
            string registrationStartDateString = $"{registrationStartDate.ToString(customDateFormat)} at {registrationStartDate.ToString(customTimeFormat)}";
            string registrationEndDateString = $"{registrationEndDate.ToString(customDateFormat)} at {registrationEndDate.ToString(customTimeFormat)}";


            string message = string.Empty;
            bool canRegister = false;

            if (currentDate > registrationEndDate || currentDate < registrationStartDate)
            {
                if (currentDate > registrationEndDate)
                {
                    message = $"Registration has ended. It started on {registrationStartDateString} and ended on {registrationEndDateString} GMT.";


                }
                else
                {
                    message = $"Registration has not started yet. It will start on {registrationStartDateString} and end on {registrationEndDateString} GMT.";

                }
            }
            else
            {
                canRegister = true;
                if (noOfRegisteredCourses > 0)
                {
                    message = $"You have completed your course registration. You can make changes until {registrationEndDate.ToString(customDateFormat)} {registrationEndDate.ToString(customTimeFormat)} GMT.";
                }
                else
                {
                    message = $"You have NOT completed your course registration. Course registration started on {registrationStartDateString} and will end on {registrationEndDateString} GMT.";
                }
            }


            registrationParameters.Message = message;
            registrationParameters.CanRegister = canRegister;
            return registrationParameters;
        }

        //private List<Academicrecord> GetRegisteredCourses(string userName, string studentId, int programmeStreamId, string app = null, int appVersion = -1)
        //{




        //}

        public async Task<AcademicRecordGetDTO> GetSemesterResultsAsync(string studentId, int acadYear, int sem)
        {
            var message = await _academicRecordRepository.GetPreResultsChecksAsync(studentId, acadYear, sem);
            if (!string.IsNullOrEmpty(message))
            {
                throw new CustomException(message);
            }

            var detailDTOs = await _academicRecordRepository.GetApprovedAcademicRecordsAsync(studentId, acadYear, sem);
            //var detailDTOs = _mapper.Map<List<AcademicRecordDetailGetDTO>>(detailEntities);
            var summaryDTO = await _academicRecordRepository.GetApprovedAcademicRecordSummaryAsync(studentId, acadYear, sem);
            return new AcademicRecordGetDTO
            {
                AcademicRecordDetails = detailDTOs,
                AcademicRecordSummary = summaryDTO
            };
        }

        public async Task<List<RegisteredCourseGetDTO>> SaveRegistrationCoursesOnlineAsync(string studentId, string username, string app, int appVersion, List<RegistrationCourseAddDTO> courses)
        {
            if(courses.Count == 0)
            {
                throw new CustomException("No courses have been selected.");
            }
            int programmeStreamId = _functionsService.GetStudentCurrentProgrammeStreamId(studentId);
            int acadYear = _functionsService.GetDefaultProgrammeStreamAcadYear(programmeStreamId);
            int sem = _functionsService.GetDefaultProgrammeStreamAcadYearSem(programmeStreamId);

            int acadLevelId = await _functionsService.GetStudentCurrentAcadLevelIdAsync(studentId, programmeStreamId, acadYear, sem);

            var academicRecordOnlineCourseList = await _academicRecordOnlineRepository.Query().Where(a => a.Studentid == studentId && a.Programmestreamid == programmeStreamId
              && a.Acadyear == acadYear && a.Sem == sem && a.Acadlevelid == acadLevelId && a.Totalmark == null).ToListAsync();
            _academicRecordOnlineRepository.Delete(academicRecordOnlineCourseList);
            await _academicRecordOnlineRepository.SaveAsync();

            List<Academicrecordonline> entities = courses.Select(
                selectedCourse =>
                new Academicrecordonline {
                    Studentid = studentId,
                    Programmestreamid = programmeStreamId,
                    Acadyear = acadYear,
                    Sem = sem,
                    Coursecode = selectedCourse.CourseCode,
                    Acadlevelid = acadLevelId,
                    Coursename = selectedCourse.CourseName,
                    Credit = selectedCourse.Credit,
                    Registeredonline = 1,
                    Istrail = 1,
                    Iscalc = 0,
                    Timeinserted = DateTime.Now,
                    Timeupdated = DateTime.Now,
                    Insertedby = username,
                    Updatedby = username,
                    Coursestatusid = null,
                    Isprevioustrail = selectedCourse.IsPreviousTrail,
                    Coursetypeid = selectedCourse.CourseTypeId == -1 ? null : selectedCourse.CourseTypeId,
                    Electivesetid = selectedCourse.ElectiveSetId == -1 ? null : selectedCourse.ElectiveSetId,
                    App = app,
                    Appversion = appVersion
                }).ToList();

            await _academicRecordOnlineRepository.InsertAsync(entities);
            await _academicRecordOnlineRepository.SaveAsync();
            return await GetOnlineRegisteredCoursesAsync(studentId, programmeStreamId, acadYear, sem, acadLevelId);
        }

        public async Task SyncAcademicRecordsAsync(string username, string studentId, string app = "AIM", int appVersion = -1)
        {
            int programmeStreamId = _functionsService.GetStudentCurrentProgrammeStreamId(studentId);
            int acadYear = _functionsService.GetDefaultProgrammeStreamAcadYear(programmeStreamId);
            int sem = _functionsService.GetDefaultProgrammeStreamAcadYearSem(programmeStreamId);
            int acadLevelId = await _functionsService.GetStudentCurrentAcadLevelIdAsync(studentId, programmeStreamId, acadYear, sem);

            List<RegisteredCourseGetDTO> selectedCourseList = await GetOnlineRegisteredCoursesAsync(studentId, programmeStreamId, acadYear, sem, acadLevelId);

            int creditRegistered = selectedCourseList.Sum(a => a.Credit);
            int unDeferredCredit = selectedCourseList.Where(a => a.CourseStatusId == null).Sum(a => a.Credit);
            int noOfElectiveSet1 = selectedCourseList.Where(a => a.ElectiveSetId == 1).Count();
            int noOfElectiveSet2 = selectedCourseList.Where(a => a.ElectiveSetId == 2).Count();
            int noOfElectiveSet3 = selectedCourseList.Where(a => a.ElectiveSetId == 3).Count();

            RegistrationParametersGetDTO registrationParameters = await GetRegistrationParameters(studentId, programmeStreamId, acadYear, sem, acadLevelId);

            List<string> parameterCheckErrors = new List<string>();

            if (unDeferredCredit < registrationParameters.MinSemCredits || unDeferredCredit > registrationParameters.MaxSemCredits)
            {
                string msg = "Credit hours cannot be less than " + registrationParameters.MinSemCredits + " or more than " + registrationParameters.MaxSemCredits + ".";
                parameterCheckErrors.Add(msg);
            }

            if (noOfElectiveSet1 < registrationParameters.MinElectiveSet1)
            {
                string courseCountString = " course ";
                if (registrationParameters.MinElectiveSet1 > 1)
                {
                    courseCountString = " courses ";
                }
                string msg = "You have to choose at least " + registrationParameters.MinElectiveSet1 + courseCountString + " from elective set 1.";
                parameterCheckErrors.Add(msg);
            }

            if (noOfElectiveSet2 < registrationParameters.MinElectiveSet2)
            {
                string courseCountString = " course ";
                if (registrationParameters.MinElectiveSet2 > 1)
                {
                    courseCountString = " courses ";
                }
                string msg = "You have to choose at least " + registrationParameters.MinElectiveSet2 + courseCountString + " from elective set 2.";
                parameterCheckErrors.Add(msg);
            }

            if (noOfElectiveSet3 < registrationParameters.MinElectiveSet3)
            {
                string courseCountString = " course ";
                if (registrationParameters.MinElectiveSet3 > 1)
                {
                    courseCountString = " courses ";
                }
                string msg = "You have to choose at least " + registrationParameters.MinElectiveSet3 + courseCountString + " from elective set 3.";
                parameterCheckErrors.Add(msg);
            }

            if (noOfElectiveSet1 > registrationParameters.MaxElectiveSet1)
            {
                string courseCountString = " course ";
                if (registrationParameters.MaxElectiveSet1 > 1)
                {
                    courseCountString = " courses ";
                }
                string msg = "You have to choose at most " + registrationParameters.MaxElectiveSet1 + courseCountString + " from elective set 1.";
                parameterCheckErrors.Add(msg);
            }

            if (noOfElectiveSet2 > registrationParameters.MaxElectiveSet2)
            {
                string courseCountString = " course ";
                if (registrationParameters.MaxElectiveSet2 > 1)
                {
                    courseCountString = " courses ";
                }
                string msg = "You have to choose at most " + registrationParameters.MaxElectiveSet2 + courseCountString + " from elective set 2.";
                parameterCheckErrors.Add(msg);
            }

            if (noOfElectiveSet3 > registrationParameters.MaxElectiveSet3)
            {
                string courseCountString = " course ";
                if (registrationParameters.MaxElectiveSet3 > 1)
                {
                    courseCountString = " courses ";
                }
                string msg = "You have to choose at most " + registrationParameters.MaxElectiveSet3 + courseCountString + " from elective set 3.";
                parameterCheckErrors.Add(msg);
            }

            if (parameterCheckErrors.Count > 0)
            {
                string parameterCheckErrorsArray = string.Join("; ", parameterCheckErrors);
                throw new CustomException(parameterCheckErrorsArray);
            }

            await _academicRecordRepository.SyncAcademicRecordsAsync(username, studentId, programmeStreamId, acadYear, sem, acadLevelId, app, appVersion);


            //var student = dbStud.STUDENT.Where(a => a.STUDENTID == studentId).First();

            //string reportname = "Registration Slip";
            //int? collegeId = dbStud.PROGRAMMESTREAM.Where(a => a.PROGRAMMESTREAMID == programmeStreamId).First().COLLEGEID;
            //string collegeEmail = dbStud.COLLEGE.Where(a => a.COLLEGEID == collegeId).First().REGISTRATIONEMAIL;

            //string techEmailSuffix = "@knust.edu.gh";
            //if (!collegeEmail.Contains(techEmailSuffix))
            //{
            //    collegeEmail = collegeEmail + techEmailSuffix;
            //}
            //string personalEmail = student.EMAIL;

            //List<string> emails = new List<string>();
            //emails.Add(personalEmail);
            //emails.Add(collegeEmail);

            //emailRegistrationSlip(reportname, studentId, acadYear, sem, emails);

            //return GetRegisteredCourses(username, studentId, programmeStreamId);
        }

        private async Task<List<RegisteredCourseGetDTO>> GetOnlineRegisteredCoursesAsync(string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId)
        {
            var registeredCourses = await _academicRecordOnlineRepository.Query().Where(a => a.Studentid == studentId && a.Programmestreamid == programmeStreamId
                   && a.Acadyear == acadYear && a.Sem == sem && a.Acadlevelid == acadLevelId)
               .Select(academicRecordOnline => new RegisteredCourseGetDTO
               {
                   Id = academicRecordOnline.Studentid.ToString() + academicRecordOnline.Programmestreamid.ToString() + academicRecordOnline.Acadyear.ToString()
                                                                   + academicRecordOnline.Sem.ToString() + academicRecordOnline.Coursecode,
                   StudentId = academicRecordOnline.Studentid,
                   ProgrammeStreamId = academicRecordOnline.Programmestreamid,
                   AcadYear = academicRecordOnline.Acadyear,
                   Sem = academicRecordOnline.Sem,
                   AcadLevelId = academicRecordOnline.Acadlevelid,
                   CourseStatusId = academicRecordOnline.Coursestatusid,
                   CourseCode = academicRecordOnline.Coursecode,
                   CourseTypeId = academicRecordOnline.Coursetypeid,
                   CourseName = academicRecordOnline.Coursename,
                   Credit = academicRecordOnline.Credit,
                   TotalMark = academicRecordOnline.Totalmark,
                   Grade = academicRecordOnline.Grade,
                    //CourseStatus = courseStatus,
                    IsPreviousTrail = academicRecordOnline.Isprevioustrail,
                   ElectiveSetId = academicRecordOnline.Electivesetid,
                   RegisteredOnline = academicRecordOnline.Registeredonline
               }).ToListAsync();

            return registeredCourses;
        }

    }
}

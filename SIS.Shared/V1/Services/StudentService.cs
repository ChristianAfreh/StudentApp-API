using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SIS.Shared.DTOs;
using SIS.Shared.Exceptions;
using SIS.Shared.Extensions;
using SIS.Shared.V1.Repositories;

namespace SIS.Shared.V1.Services
{
    public interface IStudentService
    {
        Task<StudentGetDTO> GetStudentDetailsAsync(string studentId);
        Task<List<StudentSemesterGetDTO>> GetStudentSemestersAsync(string studentId);
        Task<List<ProgrammeOptionGetDTO>> GetStudentProgrammeOptionsAvailableOnlineAsync(string studentId);
        Task UpdateStudentProgrammeOption(string studentId, StudentProgrammeOptionUpdateDTO studentProgrammeOption);
        Task<List<ProgrammeOptionGetDTO>> GetAllStudentProgrammeOptionsAsync(int programmeStreamId);
        Task<byte[]> GetPhoto(string studentId);
        Task UpdateStudentDetailsAsync(StudentUpdateDTO student);
    }


    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IStudentPhotoRepository _studentPhotoRepository;
        private readonly IStudentSemesterRepository _studentSemesterRepository;
        private readonly IProgrammeOptionRepository _programmeOptionRepository;
        private readonly IStudentProgrammeRepository _studentProgrammeRepository;
        private readonly IProgrammeSemesterRepository _programmeSemesterRepository;
        private readonly FunctionsService _functionsService;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository, IStudentPhotoRepository studentPhotoRepository, IStudentSemesterRepository studentSemesterRepository, IMapper mapper, IProgrammeOptionRepository programmeOptionRepository, FunctionsService functionsService, IProgrammeSemesterRepository programmeSemesterRepository, IStudentProgrammeRepository studentProgrammeRepository)
        {
            _studentRepository = studentRepository;
            _studentPhotoRepository = studentPhotoRepository;
            _studentSemesterRepository = studentSemesterRepository;
            _mapper = mapper;
            _programmeOptionRepository = programmeOptionRepository;
            _functionsService = functionsService;
            _programmeSemesterRepository = programmeSemesterRepository;
            _studentProgrammeRepository = studentProgrammeRepository;
        }

        private string GetFullSchoolEmail(string schoolEmail)
        {
            if (!string.IsNullOrEmpty(schoolEmail))
            {
                schoolEmail = schoolEmail.Replace(" ", "");
                string suffix = "@st.knust.edu.gh";
                if (!schoolEmail.Contains(suffix))
                {
                    schoolEmail = schoolEmail + suffix;
                }
            }
            return schoolEmail;
        }

        private string GetFullAddress(string line1, string line2, string line3, string line4)
        {
            var result = string.Empty;
            string[] lineArray = { line1, line2, line3, line4 };
            foreach (var line in lineArray)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    result += line + Environment.NewLine;
                }
            }
            result = result.Trim('\r').Trim('\n');
            return result;
        }

        public async Task<StudentGetDTO> GetStudentDetailsAsync(string studentId)
        {
            //throw new CustomException("Test xxx");
           var entity = await _studentRepository.GetStudentDetailsAsync(studentId);
            var resAdd = GetFullAddress(entity.RESADD1, entity.RESADD2, entity.RESADD3, entity.RESADD4);
            var postAdd = GetFullAddress(entity.POSTADD1, entity.POSTADD2, entity.POSTADD3, entity.POSTADD4);
            StudentGetDTO student = new StudentGetDTO
            {
                StudentId = entity.STUDENTID,
                Photo = entity.PHOTO,
                IndexNo = entity.INDEXNO,
                Title = entity.TITLE,
                Surname = entity.SURNAME,
                OtherName = entity.OTHERNAME,
                FullName = entity.FULLNAME,
                SchoolEmail = GetFullSchoolEmail(entity.SCHOOLEMAIL),
                PrimaryMobile = entity.PRIMARYMOBILE,
                SchoolMobile = entity.SCHOOLMOBILE,
                OtherPhone = entity.PHONE,
                OtherEmail = entity.EMAIL,
                RegionId = entity.REGIONID,
                Region = entity.REGION,
                Gender = entity.GENDER == "M" ? "Male" : "Female",
                BirthDate = entity.BIRTHDATE?.ToMilliseconds(),
                Country = entity.COUNTRY,
                ResAdd = resAdd,
                ResAdd1 = entity.RESADD1,
                ResAdd2 = entity.RESADD2,
                ResAdd3 = entity.RESADD3,
                ResAdd4 = entity.RESADD4,
                PostAdd = postAdd,
                PostAdd1 = entity.POSTADD1,
                PostAdd2 = entity.POSTADD2,
                PostAdd3 = entity.POSTADD3,
                PostAdd4 = entity.POSTADD4,
                ProgrammeStreamId = entity.PROGRAMMESTREAMID,
                ProgrammeStream = entity.PROGRAMMESTREAM,
                ProgrammeOption = entity.PROGRAMMEOPTION,
                PassportNo = entity.PASSPORTNO,
                ResidentialStatus = entity.ISRESIDENTIAL == true ? "Residential" : "Non-Residential",
                FeePayingStatus = entity.ISFEEPAYING == true ? "Fee-Paying" : "Regular",
                FeeCategory = entity.FEECATEGORY,
                CurrentAcadYear = entity.ACADYEAR,
                CurrentAcadYearString = entity.ACADYEARSTRING,
                CurrentSem = entity.SEM,
                CurrentYear = entity.YR,
                Campus = entity.CAMPUS,
                CollegeId = entity.COLLEGEID,
                FacultyId = entity.FACULTYID,
                DepartmentId = entity.DEPARTMENTID,
                College = entity.COLLEGE,
                Faculty = entity.FACULTY,
                Department = entity.DEPARTMENT,
                UserName = entity.SCHOOLEMAIL,
                IsInCurrentSem = entity.ISINCURRENTSEM,
                HasGraduated = entity.HASGRADUATED,
                IsEmailVerified = entity.ISEMAILCONFIRMED,
                IsFresher = entity.ISFRESHER,
                ReligionId = entity.RELIGIONID,
                ReligionName = entity.RELIGIONNAME,
                DenominationId = entity.DENOMINATIONID,
                DenominationName = entity.DENOMINATIONNAME,
                LinkedInUrl = entity.LINKEDINURL,
                IsVerificationEmailSent = entity.ISVERIFICATIONEMAILSENT
            };

            return student;
        }

        public async Task<byte[]> GetPhoto(string studentId)
        {
            var entity = await _studentPhotoRepository.GetAsync(studentId);
            if(entity == null)
            {
                throw new StudentNotFoundException();
            }

            return entity.Photo;
        }

        public async Task<List<StudentSemesterGetDTO>> GetStudentSemestersAsync(string studentId)
        {           
            var semesters = await _studentSemesterRepository.GetStudentSemestersAsync(studentId);
            return semesters;
        }

        public async Task<List<ProgrammeOptionGetDTO>> GetStudentProgrammeOptionsAvailableOnlineAsync(string studentId)
        {
            var programmeStreamId = _functionsService.GetStudentCurrentProgrammeStreamId(studentId);
            int acadYear = _functionsService.GetDefaultProgrammeStreamAcadYear(programmeStreamId);
            int sem = _functionsService.GetDefaultProgrammeStreamAcadYearSem(programmeStreamId);
            int acadLevelId = await _functionsService.GetStudentCurrentAcadLevelIdAsync(studentId, programmeStreamId, acadYear, sem);
            var semSettings = await _programmeSemesterRepository.GetSemesterSettingsAsync(programmeStreamId, acadYear, sem, acadLevelId);
            if (semSettings != null)
            {
                if (semSettings.Changeoption)
                {
                    var entities = await _programmeOptionRepository.GetProgrammeOptionsAvailableOnline(programmeStreamId);
                    return _mapper.Map<List<ProgrammeOptionGetDTO>>(entities);
                }
            }

            throw new CustomException("You are not allowed to change your programme option.");
        }

        public async Task<List<ProgrammeOptionGetDTO>> GetAllStudentProgrammeOptionsAsync(int programmeStreamId)
        {           
            var entities = await _programmeOptionRepository.GetAllProgrammeOptions(programmeStreamId);
            return _mapper.Map<List<ProgrammeOptionGetDTO>>(entities);
        }

        public async Task UpdateStudentProgrammeOption(string studentId, StudentProgrammeOptionUpdateDTO studentProgrammeOption)
        {
            if(studentId != studentProgrammeOption.StudentId)
            {
                throw new CustomException("Student ID mismatch.");
            }

            await _studentProgrammeRepository.ChangeOptionAsync(studentId, studentProgrammeOption.ProgrammeStreamId, studentProgrammeOption.OptionId);
        }

        public async Task UpdateStudentDetailsAsync(StudentUpdateDTO student)
        {
            var entity = await _studentRepository.GetAsync(student.StudentId);
            if(entity == null)
            {
                throw new StudentNotFoundException();
            }

            entity.Email = student.OtherEmail;
            entity.Primarymobile = student.PrimaryMobile;
            entity.Phone = student.OtherPhone;
            entity.Postadd1 = student.PostAdd1;
            entity.Postadd2 = student.PostAdd2;
            entity.Postadd3 = student.PostAdd3;
            entity.Postadd4 = student.PostAdd4;
            entity.Resadd1 = student.ResAdd1;
            entity.Resadd2 = student.ResAdd2;
            entity.Resadd3 = student.ResAdd3;
            entity.Resadd4 = student.ResAdd4;
            entity.Regionid = student.RegionId;
            entity.Religionid = student.ReligionId;
            entity.Denominationid = student.DenominationId;
            //entity.Linkedinurl = student.LinkedInUrl;

            _studentRepository.Update(entity);
            await _studentRepository.SaveAsync();

            //if (!string.IsNullOrEmpty(student.PrimaryMobile))
            //{
            //    string userName = entity.Schoolemail;
            //    var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            //    ApplicationUser user = UserManager.FindByName(userName);

            //    string formattedPhoneNumber = await _functionsService.GetFormattedMobileNumberAsync(student.PrimaryMobile);
            //    UserManager.SetPhoneNumber(user.Id, formattedPhoneNumber);
            //}
        }
    }
}

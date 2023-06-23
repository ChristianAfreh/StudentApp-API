using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SIS.Shared.Entities.AssessmentContext;
using SIS.Shared.Exceptions;
using SIS.Shared.V1.Repositories;

namespace SIS.Shared.V1.Services
{
    public interface IReportService
    {
        Task<byte[]> GetStudentResultSlip(string studentId, int acadYear, int sem);
        Task<byte[]> GetStudentRegistrationSlip(string studentId, int acadYear, int sem);
        Task<byte[]> GetStudentBill(string studentId, int acadYear);
        Task<byte[]> GetStudentTransactionReceipt(string studentId, string ofId);
        Task<byte[]> GetStudentFeeDetails(string studentId);

    }

    public class ReportService : IReportService
    {
        private readonly ReportGenerator _reportGenerator;
        private readonly IProgrammeStreamRepository _programmeStreamRepository;
        private readonly IStudentSemesterRepository _studentSemesterRepository;
        private readonly IStudentFeeTransactionRepository _studentFeeTransactionRepository;
        private readonly FunctionsService _functionsService;

        public ReportService(ReportGenerator reportGenerator, IProgrammeStreamRepository programmeStreamRepository, IStudentSemesterRepository semesterRepository, IStudentFeeTransactionRepository studentFeeTransactionRepository, FunctionsService functionsService)
        {
            _reportGenerator = reportGenerator;
            _programmeStreamRepository = programmeStreamRepository;
            _studentSemesterRepository = semesterRepository;
            _studentFeeTransactionRepository = studentFeeTransactionRepository;
            _functionsService = functionsService;
        }

        public async Task<byte[]> GetStudentBill(string studentId, int acadYear)
        {
            int programmeStreamId = await _functionsService.GetStudentCurrentProgrammeStreamIdAsync(studentId);

            var parameters = new Dictionary<string, string>();
            parameters.Add("STUDENTID", studentId);
            parameters.Add("PROGRAMMESTREAMID", programmeStreamId.ToString());
            parameters.Add("ACADYEAR", acadYear.ToString());
            var data = _reportGenerator.GetReport("Student Bill", parameters);
            return data;
        }

        public async Task<byte[]> GetStudentRegistrationSlip(string studentId, int acadYear, int sem)
        {
            var studentSemester = _studentSemesterRepository.Query()
                .Where(x => x.Studentid == studentId &&
                    x.Acadyear == acadYear &&
                    x.Sem == sem
                ).FirstOrDefault();
            if (studentSemester == null)
            {
                throw new CustomException("No records were found in selected semester");
            }
            var programmeStreamId = studentSemester.Programmestreamid;
            
	        int noOfRegisteredCourses = await _functionsService.GetRegisteredCourseCountAsync(studentId, programmeStreamId, acadYear, sem);

            if(noOfRegisteredCourses == 0) 
	        {
                throw new CustomException("You have not registered any courses for the selected semester.");
	        }

            var acadLevelId = studentSemester.Acadlevelid;
            var programmeStream = await _programmeStreamRepository.GetAsync(programmeStreamId);
            var programmeId = programmeStream.Programmeid;
            var timeStreamId = programmeStream.Timestreamid;

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("USERNAME", "koasante");
            parameters.Add("PROGRAMMEID", programmeId.ToString());
            parameters.Add("TIMESTREAMID", timeStreamId.ToString());
            parameters.Add("STUDENTID", studentId);
            parameters.Add("ACADYEAR", acadYear.ToString());
            parameters.Add("SEM", sem.ToString());
            parameters.Add("ACADLEVELID", acadLevelId.ToString());

            var data = _reportGenerator.GetReport("Registration Slip", parameters);
            return data;
        }

        public async Task<byte[]> GetStudentResultSlip(string studentId, int acadYear, int sem)
        {
            var studentSemester = _studentSemesterRepository.Query()
                .Where(x => x.Studentid == studentId &&
                    x.Acadyear == acadYear &&
                    x.Sem == sem
                ).FirstOrDefault();
            if(studentSemester == null)
            {
                throw new CustomException("No records were found in selected semester");
            }
            var programmeStreamId = studentSemester.Programmestreamid;
            var acadLevelId = studentSemester.Acadlevelid;
            var programmeStream = await _programmeStreamRepository.GetAsync(programmeStreamId);
            var programmeId = programmeStream.Programmeid;
            var timeStreamId = programmeStream.Timestreamid;

            var parameters = new Dictionary<string, string>();
            parameters.Add("USERNAME", "koasante");
            parameters.Add("PROGRAMMEID", programmeId.ToString());
            parameters.Add("TIMESTREAMID", timeStreamId.ToString());
            parameters.Add("STUDENTID", studentId);
            parameters.Add("ACADYEAR", acadYear.ToString());
            parameters.Add("SEM", sem.ToString());
            parameters.Add("ACADLEVELID", acadLevelId.ToString());
            parameters.Add("CAMPUSID", "-1");
            var data = _reportGenerator.GetReport("Result Slip", parameters);
            return data;
        }
    

        public async Task<byte[]> GetStudentTransactionReceipt(string studentId, string ofId)
        {
            //ofId = 3339843.ToString();
            //studentId = "20808939";
            int programmeStreamId = await _functionsService.GetStudentCurrentProgrammeStreamIdAsync(studentId);
            var transactions = await _studentFeeTransactionRepository.GetStudentFeeTransctionsAsync(studentId, programmeStreamId);

            if (transactions.Any(x => x.STUDENTID == studentId && x.OFID.ToString() == ofId))
            {
      
                Dictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("FINANCEID", ofId);
                //var data = _reportGenerator.GetReport("Student_Fee_Transaction_Receipt", parameters);
                var data = _reportGenerator.GetReport("Student Fee Transaction Receipt", parameters);
                return data;
            }
            else
            {
                throw new CustomException("You are not authorised.");
            }
        }   
        
        public async Task<byte[]> GetStudentFeeDetails(string studentId)
        {
            int programmeStreamId = await _functionsService.GetStudentCurrentProgrammeStreamIdAsync(studentId);

            var parameters = new Dictionary<string, string>();
            parameters.Add("STUDENTID", studentId);
            parameters.Add("PROGRAMMESTREAMID", programmeStreamId.ToString());
            var data = _reportGenerator.GetReport("Fee Details", parameters);
            return data;
        }
    }
}

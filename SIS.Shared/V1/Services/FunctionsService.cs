using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FeePaymentService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.AssessmentContext;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Extensions;

namespace SIS.Shared.V1.Services
{
    public class FunctionsService
    {
        private readonly SISContext _sisContext;
        private readonly AssessmentContext _assessmentContext;

        public FunctionsService(SISContext dbContext, AssessmentContext assessmentContext)
        {
            _sisContext = dbContext;
            _assessmentContext = assessmentContext;
        }

        public int GetStudentCurrentProgrammeStreamId(string studentId)
        {
            var connString = _sisContext.Database.GetConnectionString();
            int programmeStreamId = 0;
            string sql = $"SELECT dbo.getStudentCurrentProgrammeStreamID('{studentId}')";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                programmeStreamId = (int)cmd.ExecuteScalar();
            }
            return programmeStreamId;
        }  
        
        public string GetCertName(string studentId)
        {
            var connString = _sisContext.Database.GetConnectionString();
            string CertaName ="";
            string sql = $"SELECT dbo.getStudentName2({studentId})";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                CertaName = (string)cmd.ExecuteScalar();
            }
            return CertaName;
        }  
        
        public string GetGraduationStreamName(string graduationStreamId)
        {
            var connString = _sisContext.Database.GetConnectionString();
            string graduationName ="";
            string sql = $"SELECT GRADUATIONSTREAMNAME from dbo.GRADUATIONSTREAM where GRADUATIONSTREAMID = '{graduationStreamId}'";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                graduationName = (string)cmd.ExecuteScalar();
            }
            return graduationName;
        }

        public async Task<int> GetStudentCurrentProgrammeStreamIdAsync(string studentId)
        {
            var connString = _sisContext.Database.GetConnectionString();
            int programmeStreamId = 0;
            string sql = $"SELECT dbo.getStudentCurrentProgrammeStreamID('{studentId}')";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                programmeStreamId = (int)await cmd.ExecuteScalarAsync();
            }
            return programmeStreamId;
        } 

        public async Task<decimal> GetStudentTotalBalance(string studentId, int programmeStreamID)
        {
            var connString = _sisContext.Database.GetConnectionString();
            decimal studentBalance = 0;
            string sql = $"SELECT [dbo].[getStudentTotalBalance]('{studentId}','{programmeStreamID}',Null, Null)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                studentBalance = (decimal)await cmd.ExecuteScalarAsync();
            }
            return studentBalance;
        } 
        
        public async Task<GraduationPaymentViewModel> GetGraduationPayement(string studentId)
        {
            var connString = _sisContext.Database.GetConnectionString();
            GraduationPaymentViewModel Gradpayment = new GraduationPaymentViewModel();
            string sql = $"exec [dbo].[procGraduationPayment] {studentId};";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                Gradpayment = (GraduationPaymentViewModel) await cmd.ExecuteScalarAsync();
            }
            return Gradpayment;
        } 
        
      
        public int GetDefaultProgrammeStreamAcadYear(int programmeStreamId)
        {
            var connString = _sisContext.Database.GetConnectionString();
            int result = 0;
            string sql = $"SELECT dbo.getProgrammeStreamCurrentAcadYear({programmeStreamId})";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                result = (int)cmd.ExecuteScalar();
            }
            return result;
        }

        public string GetStudentMobile(string studentId)
        {
            var connString = _sisContext.Database.GetConnectionString();
            string result = string.Empty;
            string sql = $"SELECT dbo.getStudentMobile({studentId})";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                result = cmd.ExecuteScalar().ToString();
            }
            return result;
        }
        public DateTime GetServerDate()
        {
            var connString = _sisContext.Database.GetConnectionString();
            DateTime result = DateTime.Now;
            string sql = $"SELECT GETDATE()";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                result = (DateTime)cmd.ExecuteScalar();
            }
            return result;
        }

        public async Task<int> GetStudentCurrentAcadLevelIdAsync(string studentId, int programmeStreamId, int acadYear, int sem)
        {
            var connString = _sisContext.Database.GetConnectionString();
            int result = 0;
            string sql = $"SELECT dbo.getStudentCurrentLevel({studentId}, {programmeStreamId}, {acadYear}, {sem})";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                result = (int)await cmd.ExecuteScalarAsync();
            }
            return result;
        }

        public async Task<int> GetAssessmentQuestionSetId(string studentId, string courseCode)
        {
            var connString = _assessmentContext.Database.GetConnectionString();
            int result = 0;
            string sql = $"SELECT dbo.getStudentQuestionSetId('{studentId}', '{courseCode}')";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                result = (int)await cmd.ExecuteScalarAsync();
            }
            return result;
        }

        public int GetDefaultProgrammeStreamAcadYearSem(int programmeStreamId)
        {
            var connString = _sisContext.Database.GetConnectionString();
            int result = 0;
            string sql = $"SELECT dbo.getProgrammeStreamCurrentAcadYearSem({programmeStreamId})";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                result = (int)cmd.ExecuteScalar();
            }
            return result;
        }

        public async Task<int> GetRegisteredCourseCountAsync(string studentId, int programmeStreamId, int acadYear, int sem)
        {
            var connString = _sisContext.Database.GetConnectionString();
            int result = 0;
            string sql = $"SELECT dbo.getRegisterdCourseCount({studentId},{programmeStreamId},{acadYear},{sem})";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                result = (int)await cmd.ExecuteScalarAsync();
            }
            return result;
        }

        public async Task<List<TrailedCourseGetDTO>> GetSemesterOutstandingTrails(string studentId, int programmeStreamId, int acadYear, int sem)
        {
            var connString = _sisContext.Database.GetConnectionString();
            var result = new List<TrailedCourseGetDTO>();
            string sql = @$"SELECT * FROM [dbo].[OUTSTANDING_TRAILSSEM] ({studentId},{programmeStreamId},{acadYear},{sem})";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                var reader = await cmd.ExecuteReaderAsync();
                result = MapToList<TrailedCourseGetDTO>(reader).ToList();
            }
            return result;
        }

        public async Task<List<TrailedCourseGetDTO>> GetAllOutstandingTrails(string studentId, int programmeStreamId, int acadYear, int sem)
        {
            var connString = _sisContext.Database.GetConnectionString();
            var result = new List<TrailedCourseGetDTO>();
            string sql = @$"SELECT * FROM [dbo].[OUTSTANDING_TRAILSALL] ({studentId},{programmeStreamId},{acadYear},{sem})";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                var reader = await cmd.ExecuteReaderAsync();
                result = MapToList<TrailedCourseGetDTO>(reader).ToList();
            }
            return result;
        }

        public async Task<CHECKPARAMETERS_Result> GetRegistrationParameters(string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId, int optionId)
        {
            var connString = _sisContext.Database.GetConnectionString();
            CHECKPARAMETERS_Result result = null;
            string sql = @$"SELECT * FROM [dbo].[CHECKPARAMETERS] ({studentId},{programmeStreamId},{acadYear},{acadLevelId},{sem},{optionId})";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                var reader = await cmd.ExecuteReaderAsync();
                result = MapToList<CHECKPARAMETERS_Result>(reader).FirstOrDefault();
            }
            return result;
        }

        public async Task<SELECTSTUDENTSEMESTERPROGRAMME_Result> GetStudentSemesterProgramme(string studentId, int acadYear, int sem)
        {
            var connString = _sisContext.Database.GetConnectionString();
            SELECTSTUDENTSEMESTERPROGRAMME_Result result = null;
            string sql = @$"SELECT * FROM [dbo].[SELECTSTUDENTSEMESTERPROGRAMME] ({studentId},{acadYear},{sem})";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                var reader = await cmd.ExecuteReaderAsync();
                result = MapToList<SELECTSTUDENTSEMESTERPROGRAMME_Result>(reader).FirstOrDefault();
            }
            return result;
        }

        public ResultsSlipOnlineDTO ResultsSlipOnlineAsync(string studentId, int programmestreamId, int AcadYear, int Year, int Semester)
        {
			var connString = _sisContext.Database.GetConnectionString();
			ResultsSlipOnlineDTO result = null;
			string sql = @$"SELECT * FROM [dbo].[RESULT_SLIPSONLINE] ({studentId},{programmestreamId},{AcadYear}, {Year}, {Semester})";
			using (SqlConnection conn = new SqlConnection(connString))
			{
				SqlCommand cmd = new SqlCommand(sql, conn);
				conn.Open();
				var reader = cmd.ExecuteReader();
				result = MapToList<ResultsSlipOnlineDTO>(reader).FirstOrDefault();
			}
			return result;
		}

		public List<TagDetailsDTO> GetTagDetails(string studentId, int programmestreamId, int AcadYear,int Semester)
		{
			var connString = _sisContext.Database.GetConnectionString();
			List<TagDetailsDTO> result = null;
			string sql = @$"SELECT * FROM [dbo].[tblTagDetail] ({studentId},{programmestreamId},{AcadYear}, {Semester})";
			using (SqlConnection conn = new SqlConnection(connString))
			{
				SqlCommand cmd = new SqlCommand(sql, conn);
				conn.Open();
				var reader = cmd.ExecuteReader();
				result = MapToList<TagDetailsDTO>(reader).ToList();
			}
			return result;
		}

		public async Task<List<SELECTSTUDENTSEMESTERPROGRAMME_Result>> GetAllStudentSemesterProgramme(string studentId, int acadYear, int sem)
        {
            var connString = _sisContext.Database.GetConnectionString();
            List<SELECTSTUDENTSEMESTERPROGRAMME_Result> result = null;
            string sql = @$"SELECT * FROM [dbo].[SELECTSTUDENTSEMESTERPROGRAMME] ({studentId},{acadYear},{sem})";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                var reader = await cmd.ExecuteReaderAsync();
                result = MapToList<SELECTSTUDENTSEMESTERPROGRAMME_Result>(reader).ToList();
            }
            return result;
        }

        public async Task<List<tblPreAssessmentChecks_Result>> PreAssessmentChecksAsync(string studentId)
        {
            var connString = _sisContext.Database.GetConnectionString();
            var result = new List<tblPreAssessmentChecks_Result>();
            string sql = @$"SELECT * FROM [dbo].[tblPreAssessmentChecks] ({studentId})";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                var reader = await cmd.ExecuteReaderAsync();
                result = MapToList<tblPreAssessmentChecks_Result>(reader).ToList();
            }
            return result;
        }

        public async Task<List<tblAssessmentParams_Result>> GetAssessmentParametersAsync()
        {
            var connString = _sisContext.Database.GetConnectionString();
            var result = new List<tblAssessmentParams_Result>();
            string sql = @$"SELECT * FROM [dbo].[tblAssessmentParams] ()";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                var reader = await cmd.ExecuteReaderAsync();
                result = MapToList<tblAssessmentParams_Result>(reader).ToList();
            }
            return result;
        }


        private IList<T> MapToList<T>(DbDataReader dr)
        {
            var objList = new List<T>();
            var props = typeof(T).GetRuntimeProperties();

            var colMapping = dr.GetColumnSchema()
                .Where(x => props.Any(y => y.Name.ToLower() == x.ColumnName.ToLower()))
                .ToDictionary(key => key.ColumnName.ToLower());

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    T obj = Activator.CreateInstance<T>();
                    foreach (var prop in props)
                    {
                        try
                        {
                            var val = dr.GetValue(colMapping[prop.Name.ToLower()].ColumnOrdinal.Value);
                            prop.SetValue(obj, val == DBNull.Value ? null : val);
                        }
                        catch
                        {

                        }
                    }
                    objList.Add(obj);
                }
            }
            return objList;
        }

        public async Task<string> GetFormattedMobileNumberAsync(string primaryMobile)
        {
            var connString = _sisContext.Database.GetConnectionString();
            string result;
            string sql = $"SELECT dbo.getFormattedMobileNumber('{primaryMobile}')";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                result = (await cmd.ExecuteScalarAsync()).ToString();
            }

            return result;
        }

        public bool IsStudentBiometricallyVerifiedBySem(string StudentId, int AcademicYear, int Semester)
        {
			var connString = _sisContext.Database.GetConnectionString();
			bool result;
			string sql = $"SELECT dbo.getIsStudentBiometricallyVerifiedBySem({StudentId}, {AcademicYear}, {Semester})";
			using (SqlConnection conn = new SqlConnection(connString))
			{
				SqlCommand cmd = new SqlCommand(sql, conn);
				conn.Open();
				result = (bool)cmd.ExecuteScalar();
			}
			return result;
		}

		public void UpdateViewsStudentProgrammme(string studentId, int ProgrammeStreamid, int OptionId, int campusId)
		{
			var connString = _sisContext.Database.GetConnectionString();
			string sql = @$"UPDATE VIEWSTUDENTPROGRAMME SET OPTIONID={OptionId},CAMPUSID={campusId} WHERE STUDENTID={studentId} AND PROGRAMMESTREAMID={ProgrammeStreamid}";
			using (SqlConnection conn = new SqlConnection(connString))
			{
				SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
				cmd.ExecuteScalar(); 
			}
			
		}
        public async Task<List<tblGetStudentBioData_Result>> GetStudentBioData(string username)
        {
            var connString = _sisContext.Database.GetConnectionString();
            var result = new List<tblGetStudentBioData_Result>();
            string sql = @$"SELECT * FROM [trans].[tblGetStudentBioData] ('{username}')";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                var reader = await cmd.ExecuteReaderAsync();
                Console.WriteLine(reader);
                result = MapToList<tblGetStudentBioData_Result>(reader).ToList();
            }

            return result;
        }

        public async Task<List<tblGetStudentProgrammeStreamData_Result>> GetStudentProgrammeStreamData(string StudentId, int AcademicYear, int Semester)
        {
            var connString = _sisContext.Database.GetConnectionString();
            var result = new List<tblGetStudentProgrammeStreamData_Result>();

            string sql = @$"SELECT * FROM [trans].[tblGetStudentProgrammeStreamData] ('{StudentId}',{AcademicYear},{Semester})";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                var reader = await cmd.ExecuteReaderAsync();
                result = MapToList<tblGetStudentProgrammeStreamData_Result>(reader).ToList();
            }

            return result;

        }

        public async Task<int> GetDefaultCalendarAcadYear()
        {
            var connString = _sisContext.Database.GetConnectionString();
            int result;
            string sql = $"SELECT dbo.getDefaultCalendarAcadYear()";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                result = (int)await cmd.ExecuteScalarAsync();
            }

            return result;
        }
        public async Task<int> GetDefaultCalendarSem()
        {
            var connString = _sisContext.Database.GetConnectionString();
            int result;
            string sql = $"SELECT dbo.getDefaultCalendarSem()";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                result = (int)await cmd.ExecuteScalarAsync();
            }

            return result;
        }
    }
}

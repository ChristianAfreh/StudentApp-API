using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Entities.TranSwiftContext;
using SIS.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface ITranSwiftApplicantRepository : IBaseRepository<Applicant>
    {
        Task<List<SPSResult>> InsertStudentApplicant(string SurName, string UserId, string OtherNames, string Gender, DateTime DateOfBirth, string Email, string Phone, string ResidentialAddress,
            string PostalAddress, string CountryId, string StudentId, string StudentEmail, byte[] StudentPhoto, string CreatedBy);
        Task<List<SPSResult>> InsertStudentApplicantProgrammeStream(int ApplicantId, int ProgrammeStreamId, int GraduateTypeId, string SchoolRecognizedName, string StudentNumber, string IndexNo,
            int AdmissionYear, int? GraduationYear, string CreatedBy);

    }
    public class TranSwiftApplicantRepository : BaseRepository<Applicant>, ITranSwiftApplicantRepository
    {
        public TranSwiftApplicantRepository(TranscriptServiceDBContext DbContext) : base(DbContext)
        {
            
        }

        public async Task<List<SPSResult>> InsertStudentApplicant(string SurName,string UserId,string OtherNames,string Gender,DateTime DateOfBirth,string Email, string Phone,string ResidentialAddress,
            string PostalAddress, string CountryId, string StudentId,string StudentEmail, byte[] StudentPhoto,string CreatedBy)
        {
            var result = (await _appContext.LoadStoredProc("usp_APPLICANTStudentinsert")
                 .WithSqlParam("Surname", SurName)
                 .WithSqlParam("UserId", UserId)
                 .WithSqlParam("OtherNames",OtherNames)
                 .WithSqlParam("Gender", Gender)
                 .WithSqlParam("DateOfBirth", DateOfBirth)
                 .WithSqlParam("Email", Email)
                 .WithSqlParam("Phone", Phone)
                 .WithSqlParam("ResidentialAddress", ResidentialAddress)
                 .WithSqlParam("PostalAddress", PostalAddress)
                 .WithSqlParam("CountryId", CountryId)
                 .WithSqlParam("StudentId", StudentId)
                 .WithSqlParam("StudentEmail", StudentEmail)
                 .WithSqlParam("StudentPic", StudentPhoto)
                 .WithSqlParam("CreatedBy", CreatedBy)
                 .ExecuteStoredProcAsync<SPSResult>()).ToList();

            return result;
        }

        public async Task<List<SPSResult>> InsertStudentApplicantProgrammeStream(int ApplicantId, int ProgrammeStreamId, int GraduateTypeId, string SchoolRecognizedName, string StudentNumber, string IndexNo,
            int AdmissionYear, int? GraduationYear, string CreatedBy)
        {

            var result = (await _appContext.LoadStoredProc("usp_APPLICANTPROGRAMMESTREAMStudentinsert")
            .WithSqlParam("ApplicantId", ApplicantId)
            .WithSqlParam("ProgrammeStreamId", ProgrammeStreamId)
            .WithSqlParam("GraduateTypeId", GraduateTypeId)
            .WithSqlParam("SchoolRecognizedName", SchoolRecognizedName)
            .WithSqlParam("StudentNumber", StudentNumber)
            .WithSqlParam("IndexNo", IndexNo)
            .WithSqlParam("AdmissionYear", AdmissionYear)
            .WithSqlParam("GraduationYear", GraduationYear)
            .WithSqlParam("CreatedBy", CreatedBy)
            .ExecuteStoredProcAsync<SPSResult>()).ToList();

            return result;

        }


    }

    public class SPSResult
    {
        public int ResultCode { get; set; }
        public string ResultMessage { get; set; }
    }
}

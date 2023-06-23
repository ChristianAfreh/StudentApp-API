using Microsoft.EntityFrameworkCore;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface IAcademicRecordRepository : IBaseRepository<Academicrecord>
    {
        Task<string> GetPreResultsChecksAsync(string studentId, int acadYear, int sem);
        Task<string> GetPreRegistrationsChecksAsync(string studentId, int acadYear, int sem);
        Task<List<AcademicRecordDetailGetDTO>> GetApprovedAcademicRecordsAsync(string studentId, int acadYear, int sem);
        Task<List<Academicrecord>> GetSemesterRegisteredCoursesAsync(string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId);
        Task<AcademicRecordSummaryGetDTO> GetApprovedAcademicRecordSummaryAsync(string studentId, int acadYear, int sem);
        Task SyncAcademicRecordsAsync(string username, string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId, string app, int appVersion);

    }

    public class AcademicRecordRepository : BaseRepository<Academicrecord>, IAcademicRecordRepository
    {
        public AcademicRecordRepository(SISContext DbContext) : base(DbContext)
        {
        }

        public async Task<List<AcademicRecordDetailGetDTO>> GetApprovedAcademicRecordsAsync(string studentId, int acadYear, int sem)
        {
            var result = (await _appContext.LoadStoredProc("procGetAcademicRecordApprovedResult")
                 .WithSqlParam("STUDENTID", studentId)
                 .WithSqlParam("ACADYEAR", acadYear)
                 .WithSqlParam("SEM", sem)
                 .ExecuteStoredProcAsync<AcademicRecordDetailGetDTO>()).ToList();
            return result;
        }

        public async Task<AcademicRecordSummaryGetDTO> GetApprovedAcademicRecordSummaryAsync(string studentId, int acadYear, int sem)
        {
            var result = (await _appContext.LoadStoredProc("procGetAcademicRecordApprovedSummary")
                .WithSqlParam("STUDENTID", studentId)
                .WithSqlParam("ACADYEAR", acadYear)
                .WithSqlParam("SEM", sem)
                .ExecuteStoredProcAsync<AcademicRecordSummaryGetDTO>()).SingleOrDefault();
            return result;
        }

        public async Task<string> GetPreRegistrationsChecksAsync(string studentId, int acadYear, int sem)
        {
            var result = (await _appContext.LoadStoredProc("procPreRegistrationChecks")
                .WithSqlParam("STUDENTID", studentId)
                .WithSqlParam("ACADYEAR", acadYear)
                .WithSqlParam("SEM", sem)
                .ExecuteStoredProcAsync<SPStringResult>()).SingleOrDefault();
            return result.ResultMessage;
        }

        public async Task<string> GetPreResultsChecksAsync(string studentId, int acadYear, int sem)
        {
            var result = (await _appContext.LoadStoredProc("procPreResultsChecks")
                .WithSqlParam("STUDENTID", studentId)
                .WithSqlParam("ACADYEAR", acadYear)
                .WithSqlParam("SEM", sem)
                .ExecuteStoredProcAsync<SPStringResult>()).SingleOrDefault();
            return result.ResultMessage;
        }

        public async Task<List<Academicrecord>> GetSemesterRegisteredCoursesAsync(string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId)
        {
            return await Query().Where(a => a.Studentid == studentId && a.Programmestreamid == programmeStreamId
                        && a.Acadyear == acadYear && a.Sem == sem && a.Acadlevelid == acadLevelId).ToListAsync();
        }

        public async Task SyncAcademicRecordsAsync(string username, string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId, string app, int appVersion)
        {
            await _appContext.LoadStoredProc("SYNCACADEMICRECORD")
            .WithSqlParam("USERNAME", username)
            .WithSqlParam("STUDENTID", studentId)
            .WithSqlParam("PROGRAMMESTREAMID", programmeStreamId)
            .WithSqlParam("ACADYEAR", acadYear)
            .WithSqlParam("ACADLEVELID", acadLevelId)
            .WithSqlParam("SEM", sem)
            .WithSqlParam("APP", app)
            .WithSqlParam("APPVERSION", appVersion)
            .ExecuteStoredProcAsync<object>();
        }
    }

    public class SPStringResult
    {
        public string ResultMessage { get; set; }
    }
}

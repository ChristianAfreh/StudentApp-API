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
    public interface IAcademicRecordOnlineRepository : IBaseRepository<Academicrecordonline>
    {
        Task<List<Academicrecordonline>> GetSemesterRegisteredCoursesOnlineAsync(string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId);
        Task SyncAcademicRecordsOnlineAsync(string username, string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId, string app, int appVersion);
        
    }

    public class AcademicRecordOnlineRepository : BaseRepository<Academicrecordonline>, IAcademicRecordOnlineRepository
    {
        public AcademicRecordOnlineRepository(SISContext DbContext) : base(DbContext)
        {
        }

       

        public async Task SyncAcademicRecordsOnlineAsync(string username, string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId, string app, int appVersion)
        {
            await _appContext.LoadStoredProc("SYNCACADEMICRECORDSONLINE")
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

        public async Task<List<Academicrecordonline>> GetSemesterRegisteredCoursesOnlineAsync(string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId)
        {
            return await Query().Where(a => a.Studentid == studentId && a.Programmestreamid == programmeStreamId
                        && a.Acadyear == acadYear && a.Sem == sem && a.Acadlevelid == acadLevelId).ToListAsync();
        }
    }
}

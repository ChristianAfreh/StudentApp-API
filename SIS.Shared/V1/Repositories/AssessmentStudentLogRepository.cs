using SIS.Shared.Entities.AssessmentContext;
using SIS.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface IAssessmentStudentLogRepository : IBaseRepository<Studentlog>
    { 
        Task<procSTUDENTLOGInsert_Result> AddStudentAssessmentLog(Studentlog studentlog);
    }

    public class AssessmentStudentLogRepository : BaseRepository<Studentlog>, IAssessmentStudentLogRepository
    {
        public AssessmentStudentLogRepository(AssessmentContext DbContext) : base(DbContext)
        {
        }

        public async Task<procSTUDENTLOGInsert_Result> AddStudentAssessmentLog(Studentlog studentlog)
        {

            return (await _appContext.LoadStoredProc("procSTUDENTLOGInsert")
                      .WithSqlParam("SETID", studentlog.Setid)
                      .WithSqlParam("ACADYEAR", studentlog.Acadyear)
                      .WithSqlParam("SEM", studentlog.Sem)
                      .WithSqlParam("STAFFID", studentlog.Staffid)
                      .WithSqlParam("COURSECODE", studentlog.Coursecode)
                      .WithSqlParam("STUDENTID", studentlog.Studentid)
                      .ExecuteStoredProcAsync<procSTUDENTLOGInsert_Result>()).FirstOrDefault();
        }
    }
}

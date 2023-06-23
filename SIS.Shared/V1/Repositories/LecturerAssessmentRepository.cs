using SIS.Shared.Entities.AssessmentContext;
using SIS.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface ILecturerAssessmentRepository : IBaseRepository<Lecturerassessment>
    {
        Task<procLECTURERASSESSMENTInsert_Result> AddLecturerAssessmentAsync(int setId, int acadYear, int sem, string courseCode, string staffId);
    }

    public class LecturerAssessmentRepository : BaseRepository<Lecturerassessment>, ILecturerAssessmentRepository
    {
        public LecturerAssessmentRepository(AssessmentContext DbContext) : base(DbContext)
        {
        }

        public async Task<procLECTURERASSESSMENTInsert_Result> AddLecturerAssessmentAsync(int setId, int acadYear, int sem, string courseCode, string staffId)
        {
            return (await _appContext.LoadStoredProc("procLECTURERASSESSMENTInsert")
            .WithSqlParam("SETID", setId)
            .WithSqlParam("ACADYEAR", acadYear)
            .WithSqlParam("SEM", sem)
            .WithSqlParam("COURSECODE", courseCode)
            .WithSqlParam("STAFFID", staffId)
            .ExecuteStoredProcAsync<procLECTURERASSESSMENTInsert_Result>()).FirstOrDefault();
        }
    }
}

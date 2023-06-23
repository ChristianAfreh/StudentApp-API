using SIS.Shared.Entities.AssessmentContext;
using SIS.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface IAssessmentCommentRepository : IBaseRepository<Comment>
    {
        Task<procCOMMENTInsert_Result> AddAssessmentCommentAsync(int assessmentId, int questionId, string comment);
    }

    public class AssessmentCommentRepository : BaseRepository<Comment>, IAssessmentCommentRepository
    {
        public AssessmentCommentRepository(AssessmentContext DbContext) : base(DbContext)
        {
        }

        public async Task<procCOMMENTInsert_Result> AddAssessmentCommentAsync(int assessmentId, int questionId, string comment)
        {
           return (await _appContext.LoadStoredProc("procCOMMENTInsert")
           .WithSqlParam("ASSESSMENTID", assessmentId)
           .WithSqlParam("QID", questionId)
           .WithSqlParam("COMMENT", comment)
           .ExecuteStoredProcAsync<procCOMMENTInsert_Result>()).FirstOrDefault();
        }
    }
}

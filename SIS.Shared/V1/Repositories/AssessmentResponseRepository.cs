using SIS.Shared.Entities.AssessmentContext;
using SIS.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface IAssessmentResponseRepository : IBaseRepository<Response>
    {
        Task<procRESPONSEInsert_Result> AddAssessmentResponseAsync(int assessmentId, int questionId, int responseValueId);
        public Task<dynamic> AddCommentAssesmentResponseAsync(int assessmentId, int questionId, string Comment);


	}

	public class AssessmentResponseRepository : BaseRepository<Response>, IAssessmentResponseRepository
    {
        public AssessmentResponseRepository(AssessmentContext DbContext) : base(DbContext)
        {
        }

        public async Task<procRESPONSEInsert_Result> AddAssessmentResponseAsync(int assessmentId, int questionId, int responseValueId)
        {
            return (await _appContext.LoadStoredProc("procRESPONSEInsert")
            .WithSqlParam("ASSESSMENTID", assessmentId)
            .WithSqlParam("QID", questionId)
            .WithSqlParam("RESPONSEVALUEID", responseValueId)
            .ExecuteStoredProcAsync<procRESPONSEInsert_Result>()).FirstOrDefault();
        } 
        
        public async Task<dynamic> AddCommentAssesmentResponseAsync(int assessmentId, int questionId, string Comment)
        {
            return (await _appContext.LoadStoredProc("procCOMMENTInsert")
            .WithSqlParam("ASSESSMENTID", assessmentId)
            .WithSqlParam("QID", questionId)
            .WithSqlParam("COMMENT", Comment)
            .ExecuteStoredProcAsync<dynamic>()).FirstOrDefault();
        }
    }
}

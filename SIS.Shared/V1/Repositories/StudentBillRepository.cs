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
    public interface IStudentBillRepository : IBaseRepository<Studentbill>
    {
        Task<FeeSummaryGetDTO> GetFeeSummaryAsync(string studentId, int programmeStreamId);
        Task<List<ProcStudentBillResult>> GetStudentFeeScheduleItemsAsync(string studentId, int programmeStreamId, int acadYear);
    }

    public class StudentBillRepository : BaseRepository<Studentbill>, IStudentBillRepository
    {
        public StudentBillRepository(SISContext DbContext) : base(DbContext)
        {
        }

        public async Task<FeeSummaryGetDTO> GetFeeSummaryAsync(string studentId, int programmeStreamId)
        {
            return (await _appContext.LoadStoredProc("procGetStudentFeeSummary")
               .WithSqlParam("STUDENTID", studentId)
               .WithSqlParam("PROGRAMMESTREAMID", programmeStreamId)
               .ExecuteStoredProcAsync<FeeSummaryGetDTO>()).FirstOrDefault();
        }

        public async Task<List<ProcStudentBillResult>> GetStudentFeeScheduleItemsAsync(string studentId, int programmeStreamId, int acadYear)
        {
            return (await _appContext.LoadStoredProc("procStudentBill")
                .WithSqlParam("STUDENTID", studentId)
                .WithSqlParam("PROGRAMMESTREAMID", programmeStreamId)
                .WithSqlParam("ACADYEAR", acadYear)
                .ExecuteStoredProcAsync<ProcStudentBillResult>()).ToList();
        }
    }
}

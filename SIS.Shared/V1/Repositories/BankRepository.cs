using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Extensions;

namespace SIS.Shared.V1.Repositories
{
    public interface IBankRepository : IBaseRepository<Bank>
    {
        Task<List<ProcGetStudentBankResult>> GetStudentBanksAsync(string studentId, int programmeStreamId);
    }

    public class BankRepository : BaseRepository<Bank>, IBankRepository
    {
        public BankRepository(SISContext DbContext) : base(DbContext)
        {
        }

        public async Task<List<ProcGetStudentBankResult>> GetStudentBanksAsync(string studentId, int programmeStreamId)
        {
            return (await _appContext.LoadStoredProc("procWSGetStudentBank")
               .WithSqlParam("STUDENTID", studentId)
               .WithSqlParam("PROGRAMMESTREAMID", programmeStreamId)
               .ExecuteStoredProcAsync<ProcGetStudentBankResult>()).ToList();
        }
    }
}

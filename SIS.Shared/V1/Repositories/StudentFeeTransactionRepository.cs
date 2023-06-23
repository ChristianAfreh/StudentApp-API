using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Extensions;

namespace SIS.Shared.V1.Repositories
{
    public interface IStudentFeeTransactionRepository : IBaseRepository<ProcStudentFeeTransactionResult>
    {
        Task<List<ProcStudentFeeTransactionResult>> GetStudentFeeTransctionsAsync(string studentId, int programmeStreamId);
        public Task<List<ProcStudentFeeTransactionResult>> GetStudentFeePaymentAsync(string studentId, int programmeStreamId);


	}

	public class StudentFeeTransactionRepository : BaseRepository<ProcStudentFeeTransactionResult>, IStudentFeeTransactionRepository
    {
        public StudentFeeTransactionRepository(SISContext DbContext) : base(DbContext)
        {
        }

        public async Task<List<ProcStudentFeeTransactionResult>> GetStudentFeeTransctionsAsync(string studentId, int programmeStreamId)
        {
            return (await _appContext.LoadStoredProc("procStudentFeeTransactions")
               .WithSqlParam("STUDENTID", studentId)
               .WithSqlParam("PROGRAMMESTREAMID", programmeStreamId)
               .ExecuteStoredProcAsync<ProcStudentFeeTransactionResult>()).ToList();
        } 
        
        public async Task<List<ProcStudentFeeTransactionResult>> GetStudentFeePaymentAsync(string studentId, int programmeStreamId)
        {
            return (await _appContext.LoadStoredProc("procStudentFeePayments")
               .WithSqlParam("STUDENTID", studentId)
               .WithSqlParam("PROGRAMMESTREAMID", programmeStreamId)
               .ExecuteStoredProcAsync<ProcStudentFeeTransactionResult>()).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Extensions;

namespace SIS.Shared.V1.Repositories
{
    public interface IUserPaymentRepository : IBaseRepository<ViewUserpayment>
    {
        Task<PagedModel<ViewUserpayment>> GetAllPaymentsByStudentAsync(string studentId, int limit, int page, CancellationToken cancellationToken);
    }

    public class UserPaymentRepository : BaseRepository<ViewUserpayment>, IUserPaymentRepository
    {
        public UserPaymentRepository(SISContext DbContext) : base(DbContext)
        {
        }

        public Task<PagedModel<ViewUserpayment>> GetAllPaymentsByStudentAsync(string studentId, int limit, int page, CancellationToken cancellationToken)
        {
            return Query()
                .Where(x => x.Studentid == studentId)
                .AsNoTracking()
                .OrderByDescending(r => r.Transdate)
                .PaginateAsync(page, limit, cancellationToken);
        }
    }
}

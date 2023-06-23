using System;
using SIS.Shared.Entities.SISContext;

namespace SIS.Shared.V1.Repositories
{
    public interface IDenominationRepository : IBaseRepository<Denomination>
    {
    }

    public class DenominationRepository : BaseRepository<Denomination>, IDenominationRepository
    {
        public DenominationRepository(SISContext DbContext) : base(DbContext)
        {
        }
    }
}

using System;
using SIS.Shared.Entities.SISContext;

namespace SIS.Shared.V1.Repositories
{
    public interface IReligionRepository : IBaseRepository<Religion>
    {
    }

    public class ReligionRepository : BaseRepository<Religion>, IReligionRepository
    {
        public ReligionRepository(SISContext DbContext) : base(DbContext)
        {
        }
    }
}

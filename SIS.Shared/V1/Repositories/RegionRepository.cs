using SIS.Shared.Entities.SISContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface IRegionRepository : IBaseRepository<Region>
    {

    }

    public class RegionRepository : BaseRepository<Region>, IRegionRepository
    {
        public RegionRepository(SISContext DbContext) : base(DbContext)
        {
        }
    }
}

using SIS.Shared.Entities.SISContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface ICampusRepository : IBaseRepository<Campus>
    {

    }
    public  class CampusRepository : BaseRepository<Campus>, ICampusRepository
    {
        public CampusRepository(SISContext DbContext) : base(DbContext)
        {

        }
    }
}

using SIS.Shared.Entities.SISContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{

    public interface IViewupdateacademicrecordonlineRepository : IBaseRepository<Viewupdateacademicrecordonline>
    {

    }
    public class ViewupdateacademicrecordonlineRepository : BaseRepository<Viewupdateacademicrecordonline>, IViewupdateacademicrecordonlineRepository

    {
        public ViewupdateacademicrecordonlineRepository(SISContext DbContext) : base(DbContext)
        {

        }
    }
}

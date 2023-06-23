using SIS.Shared.Entities.SISContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{

	public interface IViewGraduateRepository : IBaseRepository<ViewGraduate>
	{

	}
	public class ViewGraduateRepository: BaseRepository<ViewGraduate>, IViewGraduateRepository
	{
		public ViewGraduateRepository(SISContext DbContext) : base(DbContext)
		{

		}
	}
}

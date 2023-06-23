using Microsoft.EntityFrameworkCore;
using SIS.Shared.Entities.SISContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
	public interface IGraduateRepository : IBaseRepository<Graduate>
	{
		
	}
	public class GraduateRepository: BaseRepository<Graduate>, IGraduateRepository
	{
		public GraduateRepository(SISContext DbContext): base(DbContext)
		{
				
		}

	}
}

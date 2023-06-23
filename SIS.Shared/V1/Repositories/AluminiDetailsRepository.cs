using Microsoft.EntityFrameworkCore;
using SIS.Shared.Entities.SISContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
	public interface IAluminiDetailsRepository : IBaseRepository<Alumnidetail>
	{
		Task<Alumnidetail> GetAluminiDetail(string studentId);
	}
	public class AluminiDetailsRepository: BaseRepository<Alumnidetail>, IAluminiDetailsRepository
	{
		public AluminiDetailsRepository(SISContext DbContext): base(DbContext)
		{

		}

		public async Task<Alumnidetail> GetAluminiDetail(string studentId)
		{
			return await Query()
				.Where(x => x.StudentId == studentId).FirstOrDefaultAsync();
		}

		
	}
}

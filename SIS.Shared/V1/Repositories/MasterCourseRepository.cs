using Microsoft.EntityFrameworkCore;
using SIS.Shared.Entities.SISContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface IMasterCourseRepository : IBaseRepository<Mastercourse>
    {
        public  Task<List<Mastercourse>> GetOpenElective(string studentId, int programmeStreamId, int acadYear, int sem);
    }

    public class MasterCourseRepository : BaseRepository<Mastercourse>, IMasterCourseRepository
    {
        public MasterCourseRepository(SISContext DbContext) : base(DbContext)
        {
        }
        public async Task<List<Mastercourse>> GetOpenElective(string studentId, int programmeStreamId, int acadYear, int sem)
        {
            var courses = await Query()
                .Where(m => m.Isopenelective == true
                && m.Sem == sem).ToListAsync();


            return courses;
        }
    }
}

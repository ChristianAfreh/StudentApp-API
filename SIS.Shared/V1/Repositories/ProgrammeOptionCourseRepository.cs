using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Extensions;

namespace SIS.Shared.V1.Repositories
{
    public interface IProgrammeOptionCourseRepository : IBaseRepository<Programmeoptioncourse>
    {
        //Task<List<Programmeoptioncourse>> GetCompulsoryCourses(string studentId, int programmeStreamId);
    }

    public class ProgrammeOptionCourseRepository : BaseRepository<Programmeoptioncourse>, IProgrammeOptionCourseRepository
    {
        public ProgrammeOptionCourseRepository(SISContext DbContext) : base(DbContext)
        {
        }

        
    }
}

using Microsoft.EntityFrameworkCore;
using SIS.Shared.Entities.SISContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface IViewacademicrecordonlineregRepository : IBaseRepository<Viewacademicrecordonlinereg>
    {
        Task<List<Viewacademicrecordonlinereg>> GetRegisteredCourses(string studentId, int programmeStreamId, int acadYear, int acadLevelId, int sem);
    }

    public class ViewacademicrecordonlineregRepository : BaseRepository<Viewacademicrecordonlinereg>, IViewacademicrecordonlineregRepository
    {
        public ViewacademicrecordonlineregRepository(SISContext DbContext) : base(DbContext)
        {
           
        }
        

        public async Task<List<Viewacademicrecordonlinereg>> GetRegisteredCourses(string studentId,int programmeStreamId,int acadYear,int acadLevelId,int sem)
        {
            var registeredCourses = await Query()
                .Where(a => a.Studentid == studentId &&
                a.Programmestreamid == programmeStreamId &&
                a.Acadyear == acadYear &&
                a.Acadlevelid == acadLevelId &&
                a.Sem == sem).ToListAsync();


            return registeredCourses;
        }


    }
}

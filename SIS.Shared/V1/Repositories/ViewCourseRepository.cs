using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;

namespace SIS.Shared.V1.Repositories
{
    public interface IViewCourseRepository : IBaseRepository<Viewcourse>
    {
        Task<List<Viewcourse>> GetCoursesForRegistrationAsync(string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId, int optionId);
        Task<List<Viewcourse>> GetESCourses(string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId, int optionId, int electiveSetId);
    }

    public class ViewCourseRepository : BaseRepository<Viewcourse>, IViewCourseRepository
    {
        public ViewCourseRepository(SISContext DbContext) : base(DbContext)
        {
        }

        public async Task<List<Viewcourse>> GetCoursesForRegistrationAsync(string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId, int optionId)
        {
            var courses = await Query()
                 .Where(a => a.Programmestreamid == programmeStreamId
                 && a.Acadyear == acadYear
                 && a.Sem == sem
                 && a.Acadlevelid == acadLevelId
                 && a.Coursetypeid == 1
                 && a.Optionid == optionId)
                 .ToListAsync();

            return courses;
        }

        public async Task<List<Viewcourse>> GetESCourses(string studentId, int programmeStreamId, int acadYear, int sem, int acadLevelId, int optionId, int electiveSetId)
        {
            var courses = await Query()
                .Where(a => a.Programmestreamid == programmeStreamId
                 && a.Acadyear == acadYear
                 && a.Sem == sem
                 && a.Acadlevelid == acadLevelId
                 && a.Coursetypeid == 2
                 && a.Electivesetid == electiveSetId
                 && a.Optionid == optionId)
                 .ToListAsync();

            return courses;
        }

        
       
    }
}

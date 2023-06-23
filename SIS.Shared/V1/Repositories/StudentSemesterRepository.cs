using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface IStudentSemesterRepository : IBaseRepository<Studentsemester>
    {
        Task<List<StudentSemesterGetDTO>> GetStudentSemestersAsync(string studentId);
    }

    public class StudentSemesterRepository : BaseRepository<Studentsemester>, IStudentSemesterRepository
    {
        public StudentSemesterRepository(SISContext DbContext) : base(DbContext)
        {
        }



        public async Task<List<StudentSemesterGetDTO>> GetStudentSemestersAsync(string studentId)
        {
            return (await _appContext.LoadStoredProc("procStudentSemesters")
                .WithSqlParam("STUDENTID", studentId)
                .ExecuteStoredProcAsync<StudentSemesterGetDTO>()).ToList();
        }
    }
}

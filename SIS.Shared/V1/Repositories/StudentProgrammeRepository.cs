using Microsoft.EntityFrameworkCore;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Extensions;
using SIS.Shared.V1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface IStudentProgrammeRepository : IBaseRepository<Studentprogramme>
    {
        Task<Studentprogramme> GetStudentProgrammeAsync(string studentId, int programmeStreamId);
        Task ChangeOptionAsync(string studentId, int programmeStreamId, int optionId);
    }

    public class StudentProgrammeRepository : BaseRepository<Studentprogramme>, IStudentProgrammeRepository
    {
        //private readonly FunctionsService _functionsService;




        public StudentProgrammeRepository(SISContext DbContext) : base(DbContext)
        {
        }

        public async Task ChangeOptionAsync(string studentId, int programmeStreamId, int optionId)
        {
            (await _appContext.LoadStoredProc("procChangeProgrammeOption")
               .WithSqlParam("STUDENTID", studentId)
               .WithSqlParam("PROGRAMMESTREAMID", programmeStreamId)
               .WithSqlParam("NEWOPTIONID", optionId)
               .ExecuteStoredProcAsync<object>()).FirstOrDefault();
        }

        public async Task<Studentprogramme> GetStudentProgrammeAsync(string studentId, int programmeStreamId)
        {
            return await Query()
                .Include(x => x.Programmeoption)
                .FirstOrDefaultAsync(x => x.Studentid == studentId && x.Programmestreamid == programmeStreamId);
        }
    }
}

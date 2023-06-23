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
    public interface IProgrammeSemesterRepository : IBaseRepository<Programmesemester>
    {
        Task<Programmesemester> GetSemesterSettingsAsync(int programmeStreamId, int acadYear, int sem, int acadLevelId);
    }

    public class ProgrammeSemesterRepository : BaseRepository<Programmesemester>, IProgrammeSemesterRepository
    {
    

        public ProgrammeSemesterRepository(SISContext DbContext) : base(DbContext)
        {
        }

        public async Task<Programmesemester> GetSemesterSettingsAsync(int programmeStreamId, int acadYear, int sem, int acadLevelId)
        {
            return await Query()
                .FirstOrDefaultAsync(x => x.Programmestreamid == programmeStreamId && x.Acadyear == acadYear && x.Sem == sem && x.Acadlevelid == acadLevelId);
        }
    }
}

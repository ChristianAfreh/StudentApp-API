using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Extensions;

namespace SIS.Shared.V1.Repositories
{
    public interface IProgrammeOptionRepository : IBaseRepository<Programmeoption>
    {
        Task<List<Programmeoption>> GetAllProgrammeOptions(int programmeStreamId);
        Task<List<Programmeoption>> GetProgrammeOptionsAvailableOnline(int programmeStreamId);
    }

    public class ProgrammeOptionRepository : BaseRepository<Programmeoption>, IProgrammeOptionRepository
    {
        public ProgrammeOptionRepository(SISContext DbContext) : base(DbContext)
        {
        }

        public Task<List<Programmeoption>> GetAllProgrammeOptions(int programmeStreamId)
        {
            return Query().Where(x => x.Programmestreamid == programmeStreamId).ToListAsync();
        }

        public Task<List<Programmeoption>> GetProgrammeOptionsAvailableOnline(int programmeStreamId)
        {
            return Query().Where(x => x.Programmestreamid == programmeStreamId && x.Isavailableonline == true).ToListAsync();
        }
    }
}

using System;
using SIS.Shared.Entities.SISContext;

namespace SIS.Shared.V1.Repositories
{
    public interface IProgrammeStreamRepository : IBaseRepository<Programmestream>
    {
    }

    public class ProgrammeStreamRepository : BaseRepository<Programmestream>, IProgrammeStreamRepository
    {
        public ProgrammeStreamRepository(SISContext DbContext) : base(DbContext)
        {

        }
    }
}

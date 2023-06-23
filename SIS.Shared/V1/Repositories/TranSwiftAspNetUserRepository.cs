using SIS.Shared.Entities.TranSwiftContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface ITranSwiftAspNetUserRepository : IBaseRepository<AspNetUser>
    {

    }

    public class TranSwiftAspNetUserRepository : BaseRepository<AspNetUser>, ITranSwiftAspNetUserRepository
    {
        public TranSwiftAspNetUserRepository(TranscriptServiceDBContext DbContext) : base(DbContext)
        {

        }


    }
}

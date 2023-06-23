﻿using SIS.Shared.Entities.SISContext;
using SIS.Shared.Entities.TranSwiftContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface IViewStudentphotoRepository : IBaseRepository<ViewStudentphoto>
    {

    }
    public class ViewStudentphotoRepository : BaseRepository<ViewStudentphoto>, IViewStudentphotoRepository
    {
        public ViewStudentphotoRepository(SISContext DbContext) : base(DbContext)
        {
            
        }
    }
}

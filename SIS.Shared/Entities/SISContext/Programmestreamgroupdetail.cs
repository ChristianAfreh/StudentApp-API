using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Programmestreamgroupdetail
    {
        public int Id { get; set; }
        public int Programmestreamid { get; set; }

        public virtual Programmestreamgroup IdNavigation { get; set; }
        public virtual Programmestream Programmestream { get; set; }
    }
}

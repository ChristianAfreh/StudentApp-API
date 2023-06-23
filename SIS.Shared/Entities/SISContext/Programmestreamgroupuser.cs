using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Programmestreamgroupuser
    {
        public int Id { get; set; }
        public string Userid { get; set; }

        public virtual Programmestreamgroup IdNavigation { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Programmestreamgroupfeecategory
    {
        public int Id { get; set; }
        public int Feecategoryid { get; set; }

        public virtual Feecategory Feecategory { get; set; }
        public virtual Programmestreamgroup IdNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewResidentialquotum
    {
        public string Residence { get; set; }
        public string Gender { get; set; }
        public int Quota { get; set; }
        public DateTime? Timeupdated { get; set; }
    }
}

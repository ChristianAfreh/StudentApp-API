using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Residencequotum
    {
        public int Residenceid { get; set; }
        public string Gender { get; set; }
        public int Quota { get; set; }
        public DateTime? Timeupdated { get; set; }
        public bool Blocked { get; set; }
        public int? Tol { get; set; }
    }
}

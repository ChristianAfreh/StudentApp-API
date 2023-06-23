using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentexamcentre
    {
        public string Studentid { get; set; }
        public int? Examcentreid { get; set; }
        public DateTime Timeinserted { get; set; }

        public virtual Examcentre Examcentre { get; set; }
    }
}

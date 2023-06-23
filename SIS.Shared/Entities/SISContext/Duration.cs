using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Duration
    {
        public int Durationid { get; set; }
        public string Durationname { get; set; }
        public int? Finalacadlevelid { get; set; }
        public int? Finalsem { get; set; }
    }
}

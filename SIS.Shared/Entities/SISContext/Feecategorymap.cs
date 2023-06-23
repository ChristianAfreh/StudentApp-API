using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Feecategorymap
    {
        public bool Isfreshman { get; set; }
        public bool Isforeigner { get; set; }
        public bool Isfeepaying { get; set; }
        public bool Isresidential { get; set; }
        public int Feecategoryid { get; set; }
    }
}

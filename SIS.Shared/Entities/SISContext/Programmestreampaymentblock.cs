using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Programmestreampaymentblock
    {
        public int Programmestreamid { get; set; }
        public int Admissionoffercategoryid { get; set; }
        public DateTime Timeinserted { get; set; }
        public int? Feecategoryid { get; set; }
        public bool? Isblocked { get; set; }
    }
}

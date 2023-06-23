using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentresidence
    {
        public string Studentid { get; set; }
        public int Acadyear { get; set; }
        public int? Residenceid { get; set; }
        public string Roomno { get; set; }
        public DateTime? Datebooked { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Source { get; set; }
    }
}

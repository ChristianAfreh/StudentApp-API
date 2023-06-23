using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentresidence1
    {
        public int Id { get; set; }
        public string Studentid { get; set; }
        public string AcadYear { get; set; }
        public int? Residenceid { get; set; }
        public string Roomno { get; set; }
        public DateTime? Datebooked { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Source { get; set; }
        public decimal? Billamount { get; set; }
        public DateTime Timesynced { get; set; }
    }
}

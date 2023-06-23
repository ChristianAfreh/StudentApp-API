using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Temparmisreconciled
    {
        public string Studentid { get; set; }
        public DateTime? Transdate { get; set; }
        public decimal? Amount { get; set; }
        public int? Dr { get; set; }
        public int? Cr { get; set; }
        public string Transid { get; set; }
        public string Transdetails { get; set; }
        public string Payername { get; set; }
    }
}

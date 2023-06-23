using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class StudentCredit
    {
        public string Studentid { get; set; }
        public string Currencyid { get; set; }
        public DateTime? Transdate { get; set; }
        public decimal? Amount { get; set; }
        public double Xrate { get; set; }
        public string Transtype { get; set; }
        public string Narration { get; set; }
    }
}

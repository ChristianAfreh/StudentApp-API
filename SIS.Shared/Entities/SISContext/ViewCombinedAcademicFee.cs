using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewCombinedAcademicFee
    {
        public string Studentid { get; set; }
        public int? Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Currencyid { get; set; }
        public double Amount { get; set; }
        public string Narrative { get; set; }
        public DateTime? Transdate { get; set; }
        public int? Bankid { get; set; }
        public string Transactionid { get; set; }
        public string Paymentmode { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewPaymentsGraduation
    {
        public string Studentid { get; set; }
        public int? Programmestreamid { get; set; }
        public string Currencyid { get; set; }
        public double Amount { get; set; }
        public DateTime? Transdate { get; set; }
        public int? Bankid { get; set; }
        public string Bank { get; set; }
        public string Transactionid { get; set; }
        public string Paymentmode { get; set; }
    }
}

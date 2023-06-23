using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewPayment
    {
        public string Id { get; set; }
        public string Studentid { get; set; }
        public int? Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Currencyid { get; set; }
        public double Amount { get; set; }
        public double Xrate { get; set; }
        public string Narration { get; set; }
        public DateTime? Transdate { get; set; }
        public int? Bankid { get; set; }
        public string Bankaccountno { get; set; }
        public string Transactionid { get; set; }
        public int Feeitemid { get; set; }
        public string Paymentmode { get; set; }
        public DateTime Timeinserted { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewUserpayment
    {
        public string Id { get; set; }
        public string Studentid { get; set; }
        public int? Programmestreamid { get; set; }
        public string Bankname { get; set; }
        public string Branchname { get; set; }
        public string Narrative { get; set; }
        public string Feeitemcode { get; set; }
        public string Feeitemname { get; set; }
        public DateTime? Transdate { get; set; }
        public string Transactionid { get; set; }
        public string Currencyid { get; set; }
        public string Currencyname { get; set; }
        public string Currencysymbol { get; set; }
        public double Amount { get; set; }
        public DateTime Timeinserted { get; set; }
        public bool? Isconfirmed { get; set; }
        public DateTime? Timeconfirmed { get; set; }
        public bool Isreversal { get; set; }
        public string Reversalreason { get; set; }
        public string Alttransactionid { get; set; }
        public string Paymentchannelcode { get; set; }
        public string Paymentchannelname { get; set; }
        public string Paymentservice { get; set; }
        public string Transactionstatus { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int? Accountreceiptid { get; set; }
        public string Paymenttype { get; set; }
        public bool Printreceiptallowed { get; set; }
        public bool Retryallowed { get; set; }
    }
}

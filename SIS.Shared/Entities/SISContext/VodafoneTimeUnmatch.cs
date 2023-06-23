using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class VodafoneTimeUnmatch
    {
        public string AcctCode { get; set; }
        public string BillingAcct { get; set; }
        public string ChargeCodeType { get; set; }
        public string InvoiceDate { get; set; }
        public string Msisdn { get; set; }
        public string Vodafonenumber { get; set; }
        public string OfferingName { get; set; }
        public string ProductSegregation { get; set; }
        public double? ChargeAmt { get; set; }
        public double? TaxAmt { get; set; }
        public double? Total { get; set; }
    }
}

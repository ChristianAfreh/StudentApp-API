using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentpayment
    {
        public Studentpayment()
        {
            InverseReversedtransaction = new HashSet<Studentpayment>();
        }

        public Guid Id { get; set; }
        public string Receiptno { get; set; }
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public string Currencyid { get; set; }
        public int Paymenttypeid { get; set; }
        public int? Bankid { get; set; }
        public int Paymentlocid { get; set; }
        public string Paymenttypeno { get; set; }
        public double Amount { get; set; }
        public double Xrate { get; set; }
        public DateTime Transdate { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public string Updatedby { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int? Sourceid { get; set; }
        public double? Xrate2 { get; set; }
        public double? Amount2 { get; set; }
        public int? Sourcepaymentid { get; set; }
        public string Receiptnoold { get; set; }
        public string Bankaccountno { get; set; }
        public bool? Ischecked { get; set; }
        public string Transactionid { get; set; }
        public string Narrative { get; set; }
        public Guid? Reversedtransactionid { get; set; }
        public string Reason4reversal { get; set; }
        public bool Isreversal { get; set; }
        public string Importbatchid { get; set; }
        public string Narration { get; set; }
        public int Feeitemid { get; set; }

        public virtual Bank Bank { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Feeitem Feeitem { get; set; }
        public virtual Paymentlocation Paymentloc { get; set; }
        public virtual Paymenttype Paymenttype { get; set; }
        public virtual Studentpayment Reversedtransaction { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual ICollection<Studentpayment> InverseReversedtransaction { get; set; }
    }
}

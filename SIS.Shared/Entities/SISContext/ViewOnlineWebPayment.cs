using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewOnlineWebPayment
    {
        public long Id { get; set; }
        public string Studentid { get; set; }
        public int? Programmestreamid { get; set; }
        public string Clientname { get; set; }
        public string Branchname { get; set; }
        public int Bankid { get; set; }
        public string Bankname { get; set; }
        public string Bankaccountno { get; set; }
        public string Feeitem { get; set; }
        public string Transactionid { get; set; }
        public string Narrative { get; set; }
        public string Currencyid { get; set; }
        public decimal Amount { get; set; }
        public decimal Xrate { get; set; }
        public DateTime? Transdate { get; set; }
        public DateTime Timeinserted { get; set; }
        public bool Isconfirmed { get; set; }
        public DateTime? Timeconfirmed { get; set; }
        public string Phone { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Remark { get; set; }
        public bool? Ischecked { get; set; }
        public int Feeitemid { get; set; }
        public string Teller { get; set; }
        public string Reason4reversal { get; set; }
        public string Insertedby { get; set; }
    }
}

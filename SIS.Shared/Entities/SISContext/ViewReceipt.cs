using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewReceipt
    {
        public int Receiptid { get; set; }
        public int Glaccountid { get; set; }
        public string Payername { get; set; }
        public string Transactiondetails { get; set; }
        public decimal Amount { get; set; }
        public DateTime IudDatetime { get; set; }
        public string IudBy { get; set; }
        public int? Glaccounttransid { get; set; }
        public int Accountgroupid { get; set; }
        public DateTime Transactiondate { get; set; }
        public DateTime? Posteddatetime { get; set; }
        public int? Glaccountsubid { get; set; }
        public bool Isclosed { get; set; }
        public decimal Sourceamount { get; set; }
        public string Sourcecurrencyid { get; set; }
        public string Oldreceiptid { get; set; }
        public string Chequeno { get; set; }
        public int Serialno { get; set; }
        public bool Isdeleted { get; set; }
        public DateTime? Datetimedeleted { get; set; }
        public bool Checked { get; set; }
        public bool Receiptprinted { get; set; }
        public DateTime? Oldreceiptdate { get; set; }
        public DateTime? Receiptprinteddatetime { get; set; }
        public string Sourcesystemid { get; set; }
        public string Sourcesystem { get; set; }
        public bool Isaward { get; set; }
        public DateTime? Awarddate { get; set; }
        public bool Isrevision { get; set; }
        public bool Isrestricted { get; set; }
        public string IBy { get; set; }
        public DateTime IDatetime { get; set; }
    }
}

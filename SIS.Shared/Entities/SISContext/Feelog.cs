using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Feelog
    {
        public long Logid { get; set; }
        public string Id { get; set; }
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public string Programmestream { get; set; }
        public int Acadyear { get; set; }
        public int? Sem { get; set; }
        public int? Yr { get; set; }
        public string Transactiontype { get; set; }
        public string Currencyid { get; set; }
        public double? Amount { get; set; }
        public double? Xrate { get; set; }
        public string Receiptno { get; set; }
        public string Paymenttypeno { get; set; }
        public string Bank { get; set; }
        public DateTime? Transdate { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public int? Feecategoryid { get; set; }
        public string Feecategory { get; set; }
        public string Actiontaken { get; set; }
        public DateTime Actiontime { get; set; }
        public string Username { get; set; }
        public int? Sourceid { get; set; }
        public int? Paymenttypeid { get; set; }
        public int? Bankid { get; set; }
        public string Clientnetaddress { get; set; }
    }
}

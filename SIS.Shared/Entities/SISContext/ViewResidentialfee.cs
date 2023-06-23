using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewResidentialfee
    {
        public string Studentid { get; set; }
        public string Gender { get; set; }
        public string Bankname { get; set; }
        public string Branchname { get; set; }
        public string Bankaccountno { get; set; }
        public int? Bankid { get; set; }
        public string Transactionid { get; set; }
        public string Narrative { get; set; }
        public string Currencyid { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Transdate { get; set; }
        public string Residence { get; set; }
        public DateTime Timeinserted { get; set; }
        public int? Residenceid { get; set; }
    }
}

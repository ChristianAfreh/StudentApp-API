using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Bank
    {
        public Bank()
        {
            Bankaccounts = new HashSet<Bankaccount>();
            Studentpayments = new HashSet<Studentpayment>();
            Wspaymentaccepttransactions = new HashSet<Wspaymentaccepttransaction>();
        }

        public int Bankid { get; set; }
        public string Name { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string Add4 { get; set; }
        public string Add5 { get; set; }
        public string Gid { get; set; }
        public string Accountnumber { get; set; }
        public string Accountno { get; set; }
        public bool? Isaccountnumberrequired { get; set; }
        public string Gid2 { get; set; }
        public bool? Isactive { get; set; }
        public byte[] Logo { get; set; }
        public string Shortname { get; set; }
        public bool? Isactiveoffline { get; set; }

        public virtual ICollection<Bankaccount> Bankaccounts { get; set; }
        public virtual ICollection<Studentpayment> Studentpayments { get; set; }
        public virtual ICollection<Wspaymentaccepttransaction> Wspaymentaccepttransactions { get; set; }
    }
}

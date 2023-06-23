using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Bankaccount
    {
        public Bankaccount()
        {
            Wsitemfeecategorybankaccounts = new HashSet<Wsitemfeecategorybankaccount>();
        }

        public int Bankaccountid { get; set; }
        public int Bankid { get; set; }
        public string Accountno { get; set; }
        public string Currencyid { get; set; }
        public string Name { get; set; }
        public int? Glaccountid { get; set; }
        public int? Accountgroupid { get; set; }

        public virtual Bank Bank { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual ICollection<Wsitemfeecategorybankaccount> Wsitemfeecategorybankaccounts { get; set; }
    }
}

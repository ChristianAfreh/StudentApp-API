using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Currency
    {
        public Currency()
        {
            Bankaccounts = new HashSet<Bankaccount>();
            Exchangerates = new HashSet<Exchangerate>();
            Feecategories = new HashSet<Feecategory>();
            Feeschedules = new HashSet<Feeschedule>();
            Studentfeeexemptions = new HashSet<Studentfeeexemption>();
            Studentpayments = new HashSet<Studentpayment>();
            Studentrefunds = new HashSet<Studentrefund>();
        }

        public string Currencyid { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Symbol { get; set; }
        public bool Isdefault { get; set; }
        public bool? Isactive { get; set; }

        public virtual ICollection<Bankaccount> Bankaccounts { get; set; }
        public virtual ICollection<Exchangerate> Exchangerates { get; set; }
        public virtual ICollection<Feecategory> Feecategories { get; set; }
        public virtual ICollection<Feeschedule> Feeschedules { get; set; }
        public virtual ICollection<Studentfeeexemption> Studentfeeexemptions { get; set; }
        public virtual ICollection<Studentpayment> Studentpayments { get; set; }
        public virtual ICollection<Studentrefund> Studentrefunds { get; set; }
    }
}

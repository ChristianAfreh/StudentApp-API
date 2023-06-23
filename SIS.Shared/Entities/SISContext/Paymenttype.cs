using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Paymenttype
    {
        public Paymenttype()
        {
            Studentpayments = new HashSet<Studentpayment>();
        }

        public int Paymenttypeid { get; set; }
        public string Name { get; set; }
        public bool Isbankpayment { get; set; }
        public bool? Isactive { get; set; }

        public virtual ICollection<Studentpayment> Studentpayments { get; set; }
    }
}

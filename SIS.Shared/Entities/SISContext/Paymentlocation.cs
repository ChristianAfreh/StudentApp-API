using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Paymentlocation
    {
        public Paymentlocation()
        {
            Studentpayments = new HashSet<Studentpayment>();
        }

        public int Paymentlocid { get; set; }
        public string Name { get; set; }
        public bool? Isactive { get; set; }

        public virtual ICollection<Studentpayment> Studentpayments { get; set; }
    }
}

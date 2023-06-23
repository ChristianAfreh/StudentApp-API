using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Feeitem
    {
        public Feeitem()
        {
            Studentpayments = new HashSet<Studentpayment>();
        }

        public int Feeitemid { get; set; }
        public string Feeitemname { get; set; }
        public string Feeitemcode { get; set; }

        public virtual ICollection<Studentpayment> Studentpayments { get; set; }
    }
}

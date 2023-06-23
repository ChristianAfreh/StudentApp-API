using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Refundtype
    {
        public Refundtype()
        {
            Studentrefunds = new HashSet<Studentrefund>();
        }

        public int Refundtypeid { get; set; }
        public string Refundtype1 { get; set; }

        public virtual ICollection<Studentrefund> Studentrefunds { get; set; }
    }
}

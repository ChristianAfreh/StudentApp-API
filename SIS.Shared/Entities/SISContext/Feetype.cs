using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Feetype
    {
        public Feetype()
        {
            Feeschedules = new HashSet<Feeschedule>();
        }

        public int Feetypeid { get; set; }
        public string Name { get; set; }
        public bool? Isactive { get; set; }
        public decimal Fractionrequired { get; set; }
        public int? Mappedfeetypeid { get; set; }
        public int Feegroupid { get; set; }
        public int? Feeitemid { get; set; }

        public virtual ICollection<Feeschedule> Feeschedules { get; set; }
    }
}

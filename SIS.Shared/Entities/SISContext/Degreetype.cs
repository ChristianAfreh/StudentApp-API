using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Degreetype
    {
        public Degreetype()
        {
            Degrees = new HashSet<Degree>();
        }

        public int Degreetypeid { get; set; }
        public string Degreetypename { get; set; }
        public int? Graduatetypeid { get; set; }
        public int? Degreelevel { get; set; }

        public virtual ICollection<Degree> Degrees { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Certificatetype
    {
        public Certificatetype()
        {
            Programmes = new HashSet<Programme>();
        }

        public int Certificatetypeid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Programme> Programmes { get; set; }
    }
}

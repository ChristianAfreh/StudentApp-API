using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Gradingsystemtype
    {
        public Gradingsystemtype()
        {
            Gradingsystems = new HashSet<Gradingsystem>();
        }

        public int Gradingsystemtypeid { get; set; }
        public string Name { get; set; }
        public string Shortcode { get; set; }
        public string Shortcode2 { get; set; }

        public virtual ICollection<Gradingsystem> Gradingsystems { get; set; }
    }
}

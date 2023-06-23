using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Graduatetype
    {
        public Graduatetype()
        {
            Mastercourses = new HashSet<Mastercourse>();
            Programmes = new HashSet<Programme>();
        }

        public int Graduatetypeid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Mastercourse> Mastercourses { get; set; }
        public virtual ICollection<Programme> Programmes { get; set; }
    }
}

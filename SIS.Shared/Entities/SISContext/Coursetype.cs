using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Coursetype
    {
        public Coursetype()
        {
            Programmecourses = new HashSet<Programmecourse>();
        }

        public int Coursetypeid { get; set; }
        public string Name { get; set; }
        public int? Iscore { get; set; }

        public virtual ICollection<Programmecourse> Programmecourses { get; set; }
    }
}

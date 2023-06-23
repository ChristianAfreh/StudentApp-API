using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Electiveset
    {
        public Electiveset()
        {
            Programmeoptioncourses = new HashSet<Programmeoptioncourse>();
        }

        public int Electivesetid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Programmeoptioncourse> Programmeoptioncourses { get; set; }
    }
}

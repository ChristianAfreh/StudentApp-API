using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Invigilator
    {
        public Invigilator()
        {
            Examinvigilators = new HashSet<Examinvigilator>();
        }

        public int Invigilatorid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Examinvigilator> Examinvigilators { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Placeofresidence
    {
        public Placeofresidence()
        {
            Students = new HashSet<Student>();
        }

        public int Placeofresidenceid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}

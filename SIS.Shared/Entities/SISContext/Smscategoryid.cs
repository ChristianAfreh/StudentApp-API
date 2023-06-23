using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Smscategoryid
    {
        public Smscategoryid()
        {
            Studentsms = new HashSet<Studentsm>();
        }

        public int Smscategoryid1 { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Studentsm> Studentsms { get; set; }
    }
}

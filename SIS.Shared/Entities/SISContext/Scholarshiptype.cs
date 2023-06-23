using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Scholarshiptype
    {
        public Scholarshiptype()
        {
            Studentscholarships = new HashSet<Studentscholarship>();
        }

        public int Scholarshiptypeid { get; set; }
        public string Scholarshiptype1 { get; set; }

        public virtual ICollection<Studentscholarship> Studentscholarships { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Graduationtype
    {
        public Graduationtype()
        {
            Graduationstreams = new HashSet<Graduationstream>();
        }

        public int Graduationtypeid { get; set; }
        public string Graduationtypename { get; set; }

        public virtual ICollection<Graduationstream> Graduationstreams { get; set; }
    }
}

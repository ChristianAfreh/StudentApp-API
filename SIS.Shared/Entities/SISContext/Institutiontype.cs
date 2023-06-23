using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Institutiontype
    {
        public Institutiontype()
        {
            Institutions = new HashSet<Institution>();
        }

        public int Institutiontypeid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Institution> Institutions { get; set; }
    }
}

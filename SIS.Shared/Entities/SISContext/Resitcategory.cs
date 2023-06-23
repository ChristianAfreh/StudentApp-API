using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Resitcategory
    {
        public Resitcategory()
        {
            Programmestreams = new HashSet<Programmestream>();
            Resitfeecategorymappings = new HashSet<Resitfeecategorymapping>();
        }

        public int Resitcategoryid { get; set; }
        public string Resitcategoryname { get; set; }

        public virtual ICollection<Programmestream> Programmestreams { get; set; }
        public virtual ICollection<Resitfeecategorymapping> Resitfeecategorymappings { get; set; }
    }
}

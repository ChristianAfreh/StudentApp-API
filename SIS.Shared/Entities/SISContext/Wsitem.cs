using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Wsitem
    {
        public Wsitem()
        {
            Programmestreams = new HashSet<Programmestream>();
            Wsitemfeecategories = new HashSet<Wsitemfeecategory>();
        }

        public int Wsitem1 { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Programmestream> Programmestreams { get; set; }
        public virtual ICollection<Wsitemfeecategory> Wsitemfeecategories { get; set; }
    }
}

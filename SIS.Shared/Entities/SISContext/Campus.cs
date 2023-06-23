using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Campus
    {
        public Campus()
        {
            Studentprogrammes = new HashSet<Studentprogramme>();
        }

        public int Campusid { get; set; }
        public string Name { get; set; }
        public int? Regionid { get; set; }
        public bool Isactive { get; set; }
        public bool Isdefault { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<Studentprogramme> Studentprogrammes { get; set; }
    }
}

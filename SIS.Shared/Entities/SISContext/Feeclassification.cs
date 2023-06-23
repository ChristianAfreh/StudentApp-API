using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Feeclassification
    {
        public Feeclassification()
        {
            Studentprogrammes = new HashSet<Studentprogramme>();
        }

        public int Feeclassificationid { get; set; }
        public string Name { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Insertedby { get; set; }

        public virtual ICollection<Studentprogramme> Studentprogrammes { get; set; }
    }
}

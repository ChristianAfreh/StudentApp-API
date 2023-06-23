using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Academicgroup
    {
        public Academicgroup()
        {
            Programmes = new HashSet<Programme>();
        }

        public int Academicgroupid { get; set; }
        public string Name { get; set; }
        public string Academicgroupcode { get; set; }

        public virtual ICollection<Programme> Programmes { get; set; }
    }
}

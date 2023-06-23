using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Building
    {
        public Building()
        {
            Classrooms = new HashSet<Classroom>();
        }

        public int Buildingid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Classroom> Classrooms { get; set; }
    }
}

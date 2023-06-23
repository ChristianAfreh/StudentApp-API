using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Awardclass
    {
        public Awardclass()
        {
            Gradingsystemclasses = new HashSet<Gradingsystemclass>();
        }

        public int Awardclassid { get; set; }
        public string Name { get; set; }
        public double? Weightvalue { get; set; }

        public virtual ICollection<Gradingsystemclass> Gradingsystemclasses { get; set; }
    }
}

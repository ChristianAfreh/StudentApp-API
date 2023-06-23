using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Classparameter
    {
        public Classparameter()
        {
            Studentprogrammes = new HashSet<Studentprogramme>();
        }

        public int Classid { get; set; }
        public int Programmestreamid { get; set; }
        public int Currentclass { get; set; }
        public int Gradingid { get; set; }
        public int Mincredits { get; set; }
        public int Finalyear { get; set; }
        public int Finalsem { get; set; }

        public virtual Gradingsystem Grading { get; set; }
        public virtual Programmestream Programmestream { get; set; }
        public virtual ICollection<Studentprogramme> Studentprogrammes { get; set; }
    }
}

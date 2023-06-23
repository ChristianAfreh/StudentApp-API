using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Covidvaccinetype
    {
        public Covidvaccinetype()
        {
            Studentcovidassessments = new HashSet<Studentcovidassessment>();
        }

        public int VaccineTypeId { get; set; }
        public string VaccineTypeName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Studentcovidassessment> Studentcovidassessments { get; set; }
    }
}

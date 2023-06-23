using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentcovidassessment
    {
        public int CovidAssessmentId { get; set; }
        public string StudentId { get; set; }
        public int AcadYear { get; set; }
        public int Sem { get; set; }
        public bool HasVaccinated { get; set; }
        public string VaccinationCardNumber { get; set; }
        public bool IsMohverified { get; set; }
        public int? VaccineTypeId { get; set; }
        public int? NumberOfDosesReceived { get; set; }
        public string VaccinationCenter { get; set; }
        public DateTime? VaccinationDate { get; set; }
        public DateTime Inserted { get; set; }
        public string InsertedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Student Student { get; set; }
        public virtual Covidvaccinetype VaccineType { get; set; }
    }
}

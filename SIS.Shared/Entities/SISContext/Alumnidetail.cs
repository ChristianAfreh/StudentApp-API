using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Alumnidetail
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string OtherNames { get; set; }
        public string Gender { get; set; }
        public string WhatsappNumber { get; set; }
        public string TelegramNumber { get; set; }
        public string TwitterHandle { get; set; }
        public string FacebookUrl { get; set; }
        public int CollegeId { get; set; }
        public int? DepartmentId { get; set; }
        public int ProgrammeStreamId { get; set; }
        public int? HallOfAffiliation { get; set; }
        public string NationalServiceInstitution { get; set; }
        public string ServicePostingLocation { get; set; }
        public DateTime Inserted { get; set; }
        public string InsertedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual College College { get; set; }
        public virtual Department Department { get; set; }
        public virtual Residence HallOfAffiliationNavigation { get; set; }
        public virtual Programmestream ProgrammeStream { get; set; }
        public virtual Student Student { get; set; }
    }
}

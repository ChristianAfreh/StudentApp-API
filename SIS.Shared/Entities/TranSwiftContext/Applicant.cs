using System;
using System.Collections.Generic;

namespace SIS.Shared.Entities.TranSwiftContext
{
    public partial class Applicant
    {
        public Applicant()
        {
            ApplicantPictures = new HashSet<ApplicantPicture>();
            ApplicantProgrammeStreams = new HashSet<ApplicantProgrammeStream>();
        }

        public int ApplicantId { get; set; }
        public string UserId { get; set; }
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ResidentialAddress { get; set; }
        public string PostalAddress { get; set; }
        public int CountryId { get; set; }
        public int NationalIdtypeId { get; set; }
        public string NationalIdnumber { get; set; }
        public bool IsStudent { get; set; }
        public int? StudentUserId { get; set; }
        public bool IsVerified { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual StudentUser StudentUser { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual ICollection<ApplicantPicture> ApplicantPictures { get; set; }
        public virtual ICollection<ApplicantProgrammeStream> ApplicantProgrammeStreams { get; set; }
    }
}

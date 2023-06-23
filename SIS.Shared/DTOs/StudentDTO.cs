using System;
namespace SIS.Shared.DTOs
{
    public class StudentGetDTO
    {
        public string UserName { get; set; }
        public string StudentId { get; set; }
        public string IndexNo { get; set; }
        public string Surname { get; set; }
        public string OtherName { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public long? BirthDate { get; set; }
        public string Country { get; set; }
        public int? RegionId { get; set; }
        public string Region { get; set; }
        public string SchoolEmail { get; set; }
        public string OtherPhone { get; set; }
        public string OtherEmail { get; set; }
        public string PrimaryMobile { get; set; }
        public string SchoolMobile { get; set; }
        public string ResAdd { get; set; }
        public string ResAdd1 { get; set; }
        public string ResAdd2 { get; set; }
        public string ResAdd3 { get; set; }
        public string ResAdd4 { get; set; }
        public string PostAdd { get; set; }
        public string PostAdd1 { get; set; }
        public string PostAdd2 { get; set; }
        public string PostAdd3 { get; set; }
        public string PostAdd4 { get; set; }
        public string PassportNo { get; set; }
        public int ProgrammeStreamId { get; set; }
        public string ProgrammeStream { get; set; }
        public string ProgrammeOption { get; set; }
        public int? CurrentYear { get; set; }
        public int? CurrentAcadYear { get; set; }
        public int? CurrentSem { get; set; }
        public string Campus { get; set; }
        public string ResidentialStatus { get; set; }
        public string FeeCategory { get; set; }
        public string FeePayingStatus { get; set; }
        public string PictureUrl { get; set; }
        public int? CollegeId { get; set; }
        public bool? IsInCurrentSem { get; set; }
        public bool? HasGraduated { get; set; }
        public string CurrentAcadYearString { get; internal set; }
        public int? FacultyId { get; internal set; }
        public int? DepartmentId { get; internal set; }
        public string College { get; internal set; }
        public string Faculty { get; internal set; }
        public string Department { get; internal set; }
        public byte[] Photo { get; internal set; }
        public bool? IsEmailVerified { get; set; }
        public bool? IsVerificationEmailSent { get; set; }
        public bool? IsFresher { get; set; }
        public int? ReligionId { get; set; }
        public string ReligionName { get; set; }
        public int? DenominationId { get; set; }
        public string DenominationName { get; set; }
        public string LinkedInUrl { get; set; }
    }

    public class StudentUpdateDTO
    {
        public string StudentId { get; set; }
        public string OtherEmail { get; set; }
        public string PrimaryMobile { get; set; }
        public string OtherPhone { get; set; }
        public string PostAdd1 { get; set; }
        public string PostAdd2 { get; set; }
        public string PostAdd3 { get; set; }
        public string PostAdd4 { get; set; }
        public string ResAdd1 { get; set; }
        public string ResAdd2 { get; set; }
        public string ResAdd3 { get; set; }
        public string ResAdd4 { get; set; }
        public int? RegionId { get; set; }
        public int? ReligionId { get; set; }
        public int? DenominationId { get; set; }
        public string LinkedInUrl { get; set; }
    }
}

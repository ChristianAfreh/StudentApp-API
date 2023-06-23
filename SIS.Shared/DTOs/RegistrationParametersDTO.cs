using System;
namespace SIS.Shared.DTOs
{
    public class RegistrationParametersGetDTO
    {
        public bool CanRegister { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
        public int AcadYear { get; set; }
        public int Sem { get; set; }
        public DateTime? RegistrationStartDate { get; set; }
        public DateTime? RegistrationEndDate { get; set; }
        public DateTime? CurrentDate { get; set; }
        public int OptionId { get; set; }
        public string OptionName { get; set; }
        public decimal? FeesPaid { get; set; }
        public int? MinElectiveSet1 { get; set; }
        public int? MinElectiveSet2 { get; set; }
        public int? MinElectiveSet3 { get; set; }
        public int? MaxElectiveSet1 { get; set; }
        public int? MaxElectiveSet2 { get; set; }
        public int? MaxElectiveSet3 { get; set; }
        public int? MinSemCredits { get; set; }
        public int? MaxSemCredits { get; set; }
        public bool? IncludeOpenElectives { get; set; }
        public bool? ChangeOption { get; set; }
        public int NoOfRegisteredCourses { get; set; }
        public bool IncludeTrails { get;  set; }
        public string RegistrationInstructionsUrl { get;  set; }
    }
}

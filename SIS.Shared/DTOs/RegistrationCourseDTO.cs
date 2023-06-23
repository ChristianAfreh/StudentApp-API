using System;
namespace SIS.Shared.DTOs
{
    public class RegistrationCourseGetDTO
    {
        public int AcadYear { get; set; }
        public int Sem { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public int? ElectiveSetId { get; set; }
        public int CourseTypeId { get; set; }
        public bool IsPreviousTrail { get; set; }
        public bool IsRegistered { get; set; } = false;
    }

    public class RegistrationCourseAddDTO
    {
        public int AcadYear { get; set; }
        public int Sem { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public int? ElectiveSetId { get; set; }
        public int CourseTypeId { get; set; }
        public bool IsPreviousTrail { get; set; }
    }
}

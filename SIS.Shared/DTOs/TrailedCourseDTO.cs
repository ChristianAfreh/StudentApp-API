using System;
namespace SIS.Shared.DTOs
{
    public class TrailedCourseGetDTO
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public int AcadYear { get; set; }
        public int Sem { get; set; }
        public int? TotalMark { get; set; }
        public string Grade { get; set; }
    }
}

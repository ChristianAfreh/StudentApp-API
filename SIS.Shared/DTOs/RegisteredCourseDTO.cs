using System;
namespace SIS.Shared.DTOs
{
    public class RegisteredCourseGetDTO
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public int ProgrammeStreamId { get; set; }
        public int AcadYear { get; set; }
        public int Sem { get; set; }
        public int AcadLevelId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public int? CourseStatusId { get; set; }
        public int? CourseTypeId { get; set; }
        public int? ElectiveSetId { get; set; }
        public double? TotalMark { get; set; }
        public string Grade { get; set; }
        public int RegisteredOnline { get; set; }
        public string CourseStatus { get; set; }
        public bool IsPreviousTrail { get; set; }
        public int ForumTopicCount { get; set; }
    }

    public class RegisteredCourseAddDTO
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public int ProgrammeStreamId { get; set; }
        public int AcadYear { get; set; }
        public int Sem { get; set; }
        public int Yr { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public int? CourseStatusId { get; set; }
        public int? CourseTypeId { get; set; }
        public int? ElectiveSetId { get; set; }
        public double? TotalMark { get; set; }
        public string Grade { get; set; }
        public int RegisteredOnline { get; set; }
        public string CourseStatus { get; set; }
        public bool IsPreviousTrail { get; set; }
        public int ForumTopicCount { get; set; }
    }
}

using System;
namespace SIS.Shared.DTOs
{
    public class StudentSemesterGetDTO
    {
        public string StudentId { get; set; }
        public int ProgrammestreamId { get; set; }
        public int AcadYear { get; set; }
        public string AcadYearString { get; set; }
        public int Sem { get; set; }
        public string SemString { get; set; }
        public int AcadLevelId { get; set; }
        public string AcadLevelString { get; set; }
        public string SemesterFullname { get; set; }
    }
}

using System;
namespace SIS.Shared.DTOs
{
    public class AssessmentLecturerGetDTO
    {
        public int LecturerId { get; set; }
        public int AcadYear { get; set; }
        public int Sem { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string LecturerName { get; set; }
		public byte[] Photo { get; set; }

		public bool IsAssessed { get; set; }
    }
}

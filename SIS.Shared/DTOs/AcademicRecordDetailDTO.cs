using System;
namespace SIS.Shared.DTOs
{
    public class AcademicRecordDetailGetDTO
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public double? TotalMark { get; set; }
        public string Grade { get; set; }
        public string Remark { get; set; }
    }
}

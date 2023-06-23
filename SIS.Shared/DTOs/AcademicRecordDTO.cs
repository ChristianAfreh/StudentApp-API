using System;
using System.Collections.Generic;

namespace SIS.Shared.DTOs
{
    public class AcademicRecordGetDTO
    {
        public List<AcademicRecordDetailGetDTO> AcademicRecordDetails { get; set; }
        public AcademicRecordSummaryGetDTO AcademicRecordSummary { get; set; }
    }

    public class AcademicRecordAddDTO
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public bool IsPrevious { get; set; }
        public int CourseTypeId { get; set; }
        public int ElectiveSetId { get; set; }
    }
}

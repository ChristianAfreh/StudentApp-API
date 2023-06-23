using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class AcademicSemester
    {
        public AcademicSemester()
        {
            CourseSchedules = new HashSet<CourseSchedule>();
        }

        public int AcademicSemesterId { get; set; }
        public int AcadYear { get; set; }
        public int SemesterId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsAcive { get; set; }

        public virtual Semester1 Semester { get; set; }
        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
    }
}

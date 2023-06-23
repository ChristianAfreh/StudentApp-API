using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Course
    {
        public Course()
        {
            CourseLecturer1s = new HashSet<CourseLecturer1>();
            CourseSchedules = new HashSet<CourseSchedule>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int Credit { get; set; }

        public virtual ICollection<CourseLecturer1> CourseLecturer1s { get; set; }
        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
    }
}

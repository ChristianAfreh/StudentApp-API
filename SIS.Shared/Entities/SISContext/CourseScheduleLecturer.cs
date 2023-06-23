using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class CourseScheduleLecturer
    {
        public int CourseScheduleLecturerId { get; set; }
        public int? CourseScheduleId { get; set; }
        public int LecturerId { get; set; }
        public bool? IsPrimary { get; set; }

        public virtual CourseSchedule CourseSchedule { get; set; }
        public virtual Lecturer1 Lecturer { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Lecturer1
    {
        public Lecturer1()
        {
            CourseScheduleLecturers = new HashSet<CourseScheduleLecturer>();
        }

        public int LecturerId { get; set; }
        public string LecturerTitle { get; set; }
        public string LecturerName { get; set; }
        public int? StaffId { get; set; }
        public string StaffId2 { get; set; }

        public virtual ICollection<CourseScheduleLecturer> CourseScheduleLecturers { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class CourseLecturer1
    {
        public int CourseLecturerId { get; set; }
        public int CourseId { get; set; }
        public int LecturerId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Course Course { get; set; }
    }
}

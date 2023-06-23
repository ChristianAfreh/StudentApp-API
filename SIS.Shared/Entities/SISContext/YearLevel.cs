using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class YearLevel
    {
        public YearLevel()
        {
            CourseSchedules = new HashSet<CourseSchedule>();
        }

        public int YearLevelId { get; set; }
        public string YearLevelName { get; set; }

        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
    }
}

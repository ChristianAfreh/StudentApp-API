using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TimeSlot
    {
        public TimeSlot()
        {
            CourseSchedules = new HashSet<CourseSchedule>();
        }

        public int PeriodId { get; set; }
        public int WeekDayId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }

        public virtual WeekDay WeekDay { get; set; }
        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
    }
}

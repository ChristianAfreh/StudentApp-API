using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class WeekDay
    {
        public WeekDay()
        {
            CourseSchedules = new HashSet<CourseSchedule>();
            TimeSlots = new HashSet<TimeSlot>();
        }

        public int WeekDayId { get; set; }
        public string WeekDayName { get; set; }

        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
        public virtual ICollection<TimeSlot> TimeSlots { get; set; }
    }
}

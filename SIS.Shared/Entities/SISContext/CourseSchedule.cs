using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class CourseSchedule
    {
        public CourseSchedule()
        {
            CourseScheduleLecturers = new HashSet<CourseScheduleLecturer>();
        }

        public int CourseScheduleId { get; set; }
        public int? WeekDayId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? PeriodId { get; set; }
        public int? RoomId { get; set; }
        public string Location { get; set; }
        public int AcademicSemesterId { get; set; }
        public int? ProgrammeStreamId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int? YearLevelId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public bool? Published { get; set; }

        public virtual AcademicSemester AcademicSemester { get; set; }
        public virtual Course Course { get; set; }
        public virtual TimeSlot Period { get; set; }
        public virtual ProgrammeStream1 ProgrammeStream { get; set; }
        public virtual WeekDay WeekDay { get; set; }
        public virtual YearLevel YearLevel { get; set; }
        public virtual ICollection<CourseScheduleLecturer> CourseScheduleLecturers { get; set; }
    }
}

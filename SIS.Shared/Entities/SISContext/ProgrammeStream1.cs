using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ProgrammeStream1
    {
        public ProgrammeStream1()
        {
            CourseSchedules = new HashSet<CourseSchedule>();
        }

        public int ProgrammeStreamId { get; set; }
        public string ProgrammeStreamName { get; set; }

        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
    }
}

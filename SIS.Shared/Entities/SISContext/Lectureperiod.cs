using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Lectureperiod
    {
        public Lectureperiod()
        {
            Lecturerpreferences = new HashSet<Lecturerpreference>();
            Lecturetimetables = new HashSet<Lecturetimetable>();
            Ttclassroomlectureperiods = new HashSet<Ttclassroomlectureperiod>();
        }

        public int Periodid { get; set; }
        public TimeSpan? Starttime { get; set; }
        public TimeSpan? Endtime { get; set; }
        public int Daysessionid { get; set; }

        public virtual Daysession Daysession { get; set; }
        public virtual ICollection<Lecturerpreference> Lecturerpreferences { get; set; }
        public virtual ICollection<Lecturetimetable> Lecturetimetables { get; set; }
        public virtual ICollection<Ttclassroomlectureperiod> Ttclassroomlectureperiods { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Classroom
    {
        public Classroom()
        {
            Examtimetabledetails = new HashSet<Examtimetabledetail>();
            Lecturerpreferences = new HashSet<Lecturerpreference>();
            Lecturetimetables = new HashSet<Lecturetimetable>();
            Ttclassroomlectureperiods = new HashSet<Ttclassroomlectureperiod>();
        }

        public int Classroomid { get; set; }
        public int Buildingid { get; set; }
        public string Name { get; set; }
        public int? Collegeid { get; set; }
        public int? Lecturecapacity { get; set; }
        public int? Lecturecrashcapacity { get; set; }
        public int? Examcapacity { get; set; }
        public int? Examcrashcapacity { get; set; }
        public string Shortcode { get; set; }

        public virtual Building Building { get; set; }
        public virtual College College { get; set; }
        public virtual ICollection<Examtimetabledetail> Examtimetabledetails { get; set; }
        public virtual ICollection<Lecturerpreference> Lecturerpreferences { get; set; }
        public virtual ICollection<Lecturetimetable> Lecturetimetables { get; set; }
        public virtual ICollection<Ttclassroomlectureperiod> Ttclassroomlectureperiods { get; set; }
    }
}

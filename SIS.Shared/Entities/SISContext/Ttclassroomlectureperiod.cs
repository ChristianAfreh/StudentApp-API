using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Ttclassroomlectureperiod
    {
        public Ttclassroomlectureperiod()
        {
            Tts = new HashSet<Tt>();
        }

        public int Classroomid { get; set; }
        public int Periodid { get; set; }

        public virtual Classroom Classroom { get; set; }
        public virtual Lectureperiod Period { get; set; }
        public virtual ICollection<Tt> Tts { get; set; }
    }
}

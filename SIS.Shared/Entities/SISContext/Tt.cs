using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Tt
    {
        public string Coursecode { get; set; }
        public int Lecturerid { get; set; }
        public int Classroomid { get; set; }
        public int Periodid { get; set; }
        public Guid Groupid { get; set; }

        public virtual Ttclassroomlectureperiod Ttclassroomlectureperiod { get; set; }
    }
}

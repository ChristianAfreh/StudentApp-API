using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Lecturetimetable
    {
        public int Dayid { get; set; }
        public int Periodid { get; set; }
        public int Programmeid { get; set; }
        public string Coursecode { get; set; }
        public int Yr { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Classroomid { get; set; }

        public virtual Classroom Classroom { get; set; }
        public virtual Dayofweek Day { get; set; }
        public virtual Lectureperiod Period { get; set; }
        public virtual Programme Programme { get; set; }
    }
}

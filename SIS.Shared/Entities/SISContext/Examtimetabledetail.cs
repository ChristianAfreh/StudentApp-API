using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Examtimetabledetail
    {
        public Examtimetabledetail()
        {
            Examinvigilators = new HashSet<Examinvigilator>();
        }

        public string Coursecode { get; set; }
        public int Examperiodid { get; set; }
        public int Yr { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int? Classroomid { get; set; }
        public int? Numberofstudents { get; set; }
        public int? Numbertoprint { get; set; }

        public virtual Classroom Classroom { get; set; }
        public virtual Examtimetable Examtimetable { get; set; }
        public virtual ICollection<Examinvigilator> Examinvigilators { get; set; }
    }
}

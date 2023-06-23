using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Programmecourse
    {
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int? Yr { get; set; }
        public string Coursecode { get; set; }
        public int Coursetypeid { get; set; }
        public string Coursename { get; set; }
        public int? Teachingcredit { get; set; }
        public int? Practicalcredit { get; set; }
        public int Credit { get; set; }
        public int? Estimatednumber { get; set; }
        public bool? Excludefromexamtimetable { get; set; }
        public int? Lecturerid { get; set; }
        public bool? Excludefromlecturetimetable { get; set; }
        public int Acadlevelid { get; set; }

        public virtual Mastercourse CoursecodeNavigation { get; set; }
        public virtual Coursetype Coursetype { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public virtual Programmestream Programmestream { get; set; }
        public virtual Semester Semester { get; set; }
    }
}

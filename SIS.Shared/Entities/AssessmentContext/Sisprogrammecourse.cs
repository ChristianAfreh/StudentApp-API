using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Sisprogrammecourse
    {
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Coursecode { get; set; }
        public int Coursetypeid { get; set; }
        public string Coursename { get; set; }
        public int? Teachingcredit { get; set; }
        public int? Practicalcredit { get; set; }
        public int Credit { get; set; }
        public int? Estimatednumber { get; set; }
        public bool? Excludefromexamtimetable { get; set; }
        public int? Lecturerid { get; set; }
        public bool Excludefromlecturetimetable { get; set; }
        public int Yr { get; set; }
    }
}

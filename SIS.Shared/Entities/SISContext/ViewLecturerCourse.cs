using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewLecturerCourse
    {
        public int Collegeid { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Programme { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Acadlevelid { get; set; }
        public string Coursecode { get; set; }
        public string Coursename { get; set; }
        public int Lecturerid { get; set; }
        public int Staffid { get; set; }
    }
}

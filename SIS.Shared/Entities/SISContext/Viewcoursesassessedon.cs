using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Viewcoursesassessedon
    {
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Coursecode { get; set; }
        public int Lecturerid { get; set; }
        public string Coursename { get; set; }
        public bool Published { get; set; }
    }
}

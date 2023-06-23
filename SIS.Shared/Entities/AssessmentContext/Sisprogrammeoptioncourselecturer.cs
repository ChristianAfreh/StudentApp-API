using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Sisprogrammeoptioncourselecturer
    {
        public int Optionid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Yr { get; set; }
        public string Coursecode { get; set; }
        public int Lecturerid { get; set; }
        public DateTime Lastaccess { get; set; }
    }
}

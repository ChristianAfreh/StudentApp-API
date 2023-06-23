using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Assessmentcomment
    {
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Staffid { get; set; }
        public int Setid { get; set; }
        public string Coursecode { get; set; }
        public int Qno { get; set; }
        public string Comment { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Qsetsettingcourse
    {
        public int Qsetsettingcoursesid { get; set; }
        public int Psid { get; set; }
        public int Sem { get; set; }
        public int? Yr { get; set; }
        public string Coursecode { get; set; }
        public string Coursename { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Mastercourse
    {
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public long Staffid { get; set; }
        public string Coursecode { get; set; }
        public string Coursename { get; set; }
    }
}

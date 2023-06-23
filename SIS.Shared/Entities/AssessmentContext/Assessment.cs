using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Assessment
    {
        public string Staffid { get; set; }
        public string Coursecode { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Setid { get; set; }
        public int? Qid { get; set; }
        public int Qno { get; set; }
        public int Response { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Assessmentrespondent
    {
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Staffid { get; set; }
        public int Setid { get; set; }
        public string Coursecode { get; set; }
        public int? Respondents { get; set; }
    }
}

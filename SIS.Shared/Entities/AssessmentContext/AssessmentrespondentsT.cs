using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class AssessmentrespondentsT
    {
        public int Acadyear { get; set; }
        public string Staffid { get; set; }
        public int Setid { get; set; }
        public int? Respondents { get; set; }
    }
}

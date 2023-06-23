using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class AssessmentperfgrandT
    {
        public int Acadyear { get; set; }
        public string Staffid { get; set; }
        public int Setid { get; set; }
        public decimal? Zta { get; set; }
        public int? Zt { get; set; }
        public decimal? A { get; set; }
        public string Perf { get; set; }
        public int? Respondents { get; set; }
    }
}

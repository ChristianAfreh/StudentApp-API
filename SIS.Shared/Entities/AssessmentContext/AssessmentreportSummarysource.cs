using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class AssessmentreportSummarysource
    {
        public string Staffid { get; set; }
        public string Coursecode { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Setid { get; set; }
        public string Coursename { get; set; }
        public decimal? Zta { get; set; }
        public int? Zt { get; set; }
        public decimal? A { get; set; }
        public string Perf { get; set; }
        public string Comments { get; set; }
        public int? Respondents { get; set; }
    }
}

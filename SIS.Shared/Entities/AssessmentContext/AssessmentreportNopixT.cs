using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class AssessmentreportNopixT
    {
        public string Staffid { get; set; }
        public int Acadyear { get; set; }
        public int Setid { get; set; }
        public string Fullname { get; set; }
        public decimal? Zta { get; set; }
        public int? Zt { get; set; }
        public decimal? A { get; set; }
        public string Perf { get; set; }
        public string Department { get; set; }
        public string Faculty { get; set; }
        public string College { get; set; }
        public int? Respondents { get; set; }
    }
}

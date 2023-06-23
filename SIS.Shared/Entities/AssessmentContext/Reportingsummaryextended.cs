using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Reportingsummaryextended
    {
        public long Reportingsummaryid { get; set; }
        public int Setid { get; set; }
        public string Staffid { get; set; }
        public string Coursecode { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Coursename { get; set; }
        public decimal? Zta { get; set; }
        public int? Zt { get; set; }
        public decimal? A { get; set; }
        public string Perf { get; set; }
        public string Comments { get; set; }
        public int? Respondents { get; set; }
        public int Departmentid { get; set; }
        public int? Facultyid { get; set; }
        public int? Collegeid { get; set; }
        public string Fullname { get; set; }
        public int? Respondentsexpected { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Assessmentunit
    {
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int? Departmentid { get; set; }
        public int? Facultyid { get; set; }
        public int? Collegeid { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class AssessmentdepartmentCopy
    {
        public string Staffid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Setid { get; set; }
        public string Coursecode { get; set; }
        public int Programmestreamid { get; set; }
        public int? Departmentid { get; set; }
        public int? Facultyid { get; set; }
        public int? Collegeid { get; set; }
    }
}

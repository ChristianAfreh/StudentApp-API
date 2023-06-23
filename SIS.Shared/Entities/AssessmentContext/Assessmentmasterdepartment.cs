using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Assessmentmasterdepartment
    {
        public string Staffid { get; set; }
        public string Coursecode { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Departmentid { get; set; }
        public string Department { get; set; }
    }
}

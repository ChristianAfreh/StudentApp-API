using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Department
    {
        public int Departmentid { get; set; }
        public int? Facultyid { get; set; }
        public int? Collegeid { get; set; }
        public string Name { get; set; }
    }
}

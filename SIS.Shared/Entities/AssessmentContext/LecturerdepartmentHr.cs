using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class LecturerdepartmentHr
    {
        public long? Staffid { get; set; }
        public int Departmentid { get; set; }
        public string Department { get; set; }
        public int? Facultyid { get; set; }
    }
}

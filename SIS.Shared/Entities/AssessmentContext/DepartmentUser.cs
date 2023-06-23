using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class DepartmentUser
    {
        public int Userid { get; set; }
        public int Departmentid { get; set; }
        public string Username { get; set; }
        public string DepartmentName { get; set; }
        public string Role { get; set; }
    }
}

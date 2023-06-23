using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class StaffnameLocDelete
    {
        public int Staffid { get; set; }
        public string Fullname { get; set; }
        public string Department { get; set; }
        public string Faculty { get; set; }
        public string College { get; set; }
        public string Techmail { get; set; }
    }
}

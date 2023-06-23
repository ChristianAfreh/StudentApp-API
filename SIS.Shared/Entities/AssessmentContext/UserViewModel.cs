using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class UserViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string StaffId { get; set; }
        public string Name { get; set; }
        public int Role { get; set; }
    }
}

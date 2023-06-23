using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class User
    {
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Staffid { get; set; }
        public int Role { get; set; }
        public string Name { get; set; }
        public DateTime? Lastlogin { get; set; }
        public string Clientip { get; set; }
        public int? Logins { get; set; }
    }
}

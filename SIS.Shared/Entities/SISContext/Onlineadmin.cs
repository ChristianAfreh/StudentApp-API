using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Onlineadmin
    {
        public string Username { get; set; }
        public string Pass { get; set; }
        public bool? Logincreated { get; set; }
        public string Logincreateerror { get; set; }
    }
}

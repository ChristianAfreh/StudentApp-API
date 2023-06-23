using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentloginlog
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime Lastlogin { get; set; }
        public string Hostname { get; set; }
        public string Browser { get; set; }
        public string Clientnetaddress { get; set; }
        public string App { get; set; }
        public string Devicename { get; set; }
        public string Os { get; set; }
    }
}

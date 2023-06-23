using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Userloginlog
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public DateTime Logintime { get; set; }
        public string Clientnetaddress { get; set; }
        public int? Sessionid { get; set; }
        public int? Hostid { get; set; }
        public string Hostname { get; set; }
        public string Clientappname { get; set; }
        public string Activity { get; set; }
        public string Appversion { get; set; }
    }
}

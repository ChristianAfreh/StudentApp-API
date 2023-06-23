using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentpassreset
    {
        public string Username { get; set; }
        public string App { get; set; }
        public bool Isreset { get; set; }
        public DateTime Datetimeinserted { get; set; }
        public string Insertedby { get; set; }
        public string Hostname { get; set; }
        public string Browser { get; set; }
        public string Clientnetaddress { get; set; }
        public string Devicename { get; set; }
        public string Os { get; set; }
    }
}

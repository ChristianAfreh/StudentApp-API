using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class StudentAt
    {
        public long Id { get; set; }
        public DateTime Actiontime { get; set; }
        public string Studentid { get; set; }
        public string Fieldaffected { get; set; }
        public string Fielddescription { get; set; }
        public string Recorddata { get; set; }
        public string Actiontaken { get; set; }
        public string Oldvalue { get; set; }
        public string Newvalue { get; set; }
        public string Username { get; set; }
        public string Hostname { get; set; }
        public string Clientnetaddress { get; set; }
    }
}

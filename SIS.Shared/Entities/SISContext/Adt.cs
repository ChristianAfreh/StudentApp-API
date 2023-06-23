using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Adt
    {
        public long Id { get; set; }
        public long? Sourceid { get; set; }
        public DateTime Actiontime { get; set; }
        public string Studentid { get; set; }
        public string Programmestreamid { get; set; }
        public int? Acadyear { get; set; }
        public int? Sem { get; set; }
        public string Tableaffected { get; set; }
        public string Fieldaffected { get; set; }
        public string Fielddescription { get; set; }
        public string Recorddata { get; set; }
        public string Actiontaken { get; set; }
        public string Oldvalue { get; set; }
        public string Newvalue { get; set; }
        public string Dbusername { get; set; }
        public string Appusername { get; set; }
        public string Hostname { get; set; }
        public int? Hostid { get; set; }
        public string Clientnetaddress { get; set; }
    }
}

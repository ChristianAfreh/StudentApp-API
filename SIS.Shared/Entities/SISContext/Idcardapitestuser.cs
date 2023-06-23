using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Idcardapitestuser
    {
        public string Clientid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Postaladdress { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Type { get; set; }
        public string Expires { get; set; }
        public string Status { get; set; }
        public string Gender { get; set; }
    }
}

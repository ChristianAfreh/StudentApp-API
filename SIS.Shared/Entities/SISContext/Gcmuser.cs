using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Gcmuser
    {
        public int Id { get; set; }
        public string Studentid { get; set; }
        public string Username { get; set; }
        public string Gcmregid { get; set; }
        public string Senderid { get; set; }
        public DateTime Datetimeinserted { get; set; }
        public string Deviceid { get; set; }
        public DateTime? Datetimeupdated { get; set; }
    }
}

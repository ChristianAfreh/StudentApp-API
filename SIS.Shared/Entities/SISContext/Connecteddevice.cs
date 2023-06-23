using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Connecteddevice
    {
        public string Deviceid { get; set; }
        public string Studentid { get; set; }
        public string Devicename { get; set; }
        public string App { get; set; }
        public string Location { get; set; }
        public string Operatingsystem { get; set; }
        public string Fcmregid { get; set; }
        public string Fcmsenderid { get; set; }
        public int? Appversioncode { get; set; }
        public string Appversionname { get; set; }
        public DateTime Datetimeinserted { get; set; }
        public DateTime? Datetimeupdated { get; set; }
    }
}

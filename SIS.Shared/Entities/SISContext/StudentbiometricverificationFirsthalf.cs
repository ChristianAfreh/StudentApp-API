using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class StudentbiometricverificationFirsthalf
    {
        public string Studentid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public string Clientnetaddress { get; set; }
    }
}

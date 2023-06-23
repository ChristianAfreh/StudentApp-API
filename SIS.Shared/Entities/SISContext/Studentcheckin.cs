using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentcheckin
    {
        public string Studentid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public DateTime Checkindatetime { get; set; }
        public string Checkinby { get; set; }
    }
}

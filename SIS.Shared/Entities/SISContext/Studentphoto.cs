using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentphoto
    {
        public string Studentid { get; set; }
        public byte[] Photo { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public Guid? Sourcerowguid { get; set; }
    }
}

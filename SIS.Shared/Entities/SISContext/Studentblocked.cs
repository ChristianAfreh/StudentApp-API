using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentblocked
    {
        public int Id { get; set; }
        public string Studentid { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Reason { get; set; }
        public string Insertedby { get; set; }
        public bool? Isblocked { get; set; }
    }
}

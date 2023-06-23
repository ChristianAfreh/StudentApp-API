using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ResidencebookingBackup
    {
        public string Studentid { get; set; }
        public int Residenceid { get; set; }
        public int Acadyear { get; set; }
        public bool Isreserved { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public long Id { get; set; }
        public long Bookingcode { get; set; }
        public bool Ispaid { get; set; }
        public string Action { get; set; }
        public int? Bookingtypeid { get; set; }
        public DateTime? Bookingdeadline { get; set; }
    }
}

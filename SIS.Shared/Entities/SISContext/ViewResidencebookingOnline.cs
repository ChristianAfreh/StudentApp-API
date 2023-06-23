using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewResidencebookingOnline
    {
        public long Id { get; set; }
        public string Studentid { get; set; }
        public string Surname { get; set; }
        public string Othername { get; set; }
        public int Acadyear { get; set; }
        public int Residenceid { get; set; }
        public int? Altresidenceid { get; set; }
        public string Residence { get; set; }
        public string Gender { get; set; }
        public DateTime Bookingdate { get; set; }
        public DateTime? Bookingdeadline { get; set; }
        public long Bookingcode { get; set; }
        public string Insertedby { get; set; }
        public bool Ispaid { get; set; }
        public bool Isreserved { get; set; }
        public string Roomno { get; set; }
        public int? Bookingtypeid { get; set; }
    }
}

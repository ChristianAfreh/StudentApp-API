using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Residencebookinglog
    {
        public long Logid { get; set; }
        public long? Id { get; set; }
        public string Studentid { get; set; }
        public int Residenceid { get; set; }
        public int Acadyear { get; set; }
        public long Bookingcode { get; set; }
        public bool Isreserved { get; set; }
        public bool Ispaid { get; set; }
        public string Roomno { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public string Clientnetaddress { get; set; }
        public string Username { get; set; }
        public string Actiontaken { get; set; }
        public DateTime Actiontime { get; set; }
        public string Fieldmodified { get; set; }
        public string Oldvalue { get; set; }
        public string Newvalue { get; set; }
    }
}

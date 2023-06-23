using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewFresher1
    {
        public string Studentid { get; set; }
        public string Surname { get; set; }
        public string Othername { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Countryid { get; set; }
        public string Countryname { get; set; }
        public string Programmestream { get; set; }
        public int Programmestreamid { get; set; }
        public string Residence { get; set; }
        public int? Admmode { get; set; }
        public DateTime Timeinserted { get; set; }
        public int? Residenceid { get; set; }
    }
}

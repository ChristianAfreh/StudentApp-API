using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Viewstudidentity
    {
        public string Studentid { get; set; }
        public string Schoolemail { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Resadd1 { get; set; }
        public string Resadd2 { get; set; }
        public string Resadd3 { get; set; }
        public string Resadd4 { get; set; }
        public string Postadd1 { get; set; }
        public string Postadd2 { get; set; }
        public string Postadd3 { get; set; }
        public string Postadd4 { get; set; }
        public string Surname { get; set; }
        public string Othername { get; set; }
        public int? Titleid { get; set; }
        public string Gender { get; set; }
        public byte[] Picture { get; set; }
        public string Countryid { get; set; }
        public int? Regionid { get; set; }
        public string Primarymobile { get; set; }
        public string Schoolmobile { get; set; }
        public int? Placeofresidenceid { get; set; }
        public int? Currentresidenceid { get; set; }
        public int? Religionid { get; set; }
        public int? Denominationid { get; set; }
        public string Denomination { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}

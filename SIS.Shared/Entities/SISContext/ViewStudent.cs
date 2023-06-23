using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewStudent
    {
        public string Studentid { get; set; }
        public int? Programmestreamid { get; set; }
        public string Programmestream { get; set; }
        public string Surname { get; set; }
        public string Othername { get; set; }
        public string Studentname { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Schoolemail { get; set; }
        public string Schoolpwd { get; set; }
        public string Primarymobile { get; set; }
        public string Schoolmobile { get; set; }
        public string Countryid { get; set; }
        public int? Acadyearenrolled { get; set; }
        public int? Feecategoryid { get; set; }
        public int? Tagid { get; set; }
    }
}

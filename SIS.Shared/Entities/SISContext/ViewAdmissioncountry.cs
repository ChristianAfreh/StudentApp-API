using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewAdmissioncountry
    {
        public string Countryid { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Phonecode { get; set; }
        public string Countrycode2 { get; set; }
        public string Phonecode2 { get; set; }
        public int? Countryorder { get; set; }
    }
}

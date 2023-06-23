using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Country
    {
        public Country()
        {
            Regions = new HashSet<Region>();
            Transcriptrequestdetails = new HashSet<Transcriptrequestdetail>();
        }

        public string Countryid { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Phonecode { get; set; }

        public virtual ICollection<Region> Regions { get; set; }
        public virtual ICollection<Transcriptrequestdetail> Transcriptrequestdetails { get; set; }
    }
}

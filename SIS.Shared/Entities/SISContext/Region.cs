using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Region
    {
        public Region()
        {
            Campuses = new HashSet<Campus>();
        }

        public int Regionid { get; set; }
        public string Countryid { get; set; }
        public string Name { get; set; }
        public string Shortcode { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Campus> Campuses { get; set; }
    }
}

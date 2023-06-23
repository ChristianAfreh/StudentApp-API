using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Programmestreamgroup
    {
        public Programmestreamgroup()
        {
            Programmestreamgroupdetails = new HashSet<Programmestreamgroupdetail>();
            Programmestreamgroupfeecategories = new HashSet<Programmestreamgroupfeecategory>();
            Programmestreamgroupusers = new HashSet<Programmestreamgroupuser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Unitid { get; set; }

        public virtual ICollection<Programmestreamgroupdetail> Programmestreamgroupdetails { get; set; }
        public virtual ICollection<Programmestreamgroupfeecategory> Programmestreamgroupfeecategories { get; set; }
        public virtual ICollection<Programmestreamgroupuser> Programmestreamgroupusers { get; set; }
    }
}

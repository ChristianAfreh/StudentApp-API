using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Feecategory
    {
        public Feecategory()
        {
            Feeschedules = new HashSet<Feeschedule>();
            Programmestreamgroupfeecategories = new HashSet<Programmestreamgroupfeecategory>();
            Resitfeecategorymappings = new HashSet<Resitfeecategorymapping>();
            Studentfeecategories = new HashSet<Studentfeecategory>();
            Wsitemfeecategories = new HashSet<Wsitemfeecategory>();
        }

        public int Feecategoryid { get; set; }
        public string Name { get; set; }
        public string Currencyid { get; set; }
        public int? Nextfeecategoryid { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public int? Studentcategoryid { get; set; }
        public int? Feeclassificationid { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual ICollection<Feeschedule> Feeschedules { get; set; }
        public virtual ICollection<Programmestreamgroupfeecategory> Programmestreamgroupfeecategories { get; set; }
        public virtual ICollection<Resitfeecategorymapping> Resitfeecategorymappings { get; set; }
        public virtual ICollection<Studentfeecategory> Studentfeecategories { get; set; }
        public virtual ICollection<Wsitemfeecategory> Wsitemfeecategories { get; set; }
    }
}

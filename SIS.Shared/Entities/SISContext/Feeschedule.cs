using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Feeschedule
    {
        public int Programmestreamid { get; set; }
        public int Feecategoryid { get; set; }
        public int Feetypeid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Acadlevelid { get; set; }
        public string Currencyid { get; set; }
        public decimal Amount { get; set; }
        public bool Iscore { get; set; }
        public DateTime? Timeinserted { get; set; }
        public DateTime? Timeupdated { get; set; }
        public string Insertedby { get; set; }
        public string Updatedby { get; set; }
        public decimal Fractionrequired { get; set; }
        public int Id { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual Feecategory Feecategory { get; set; }
        public virtual Feetype Feetype { get; set; }
        public virtual Programmestream Programmestream { get; set; }
        public virtual Semester Semester { get; set; }
    }
}

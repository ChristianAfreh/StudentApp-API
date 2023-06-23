using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Resitfeecategorymapping
    {
        public int Resitcategoryid { get; set; }
        public int Feecategoryid { get; set; }
        public int Resittemplateid { get; set; }
        public string Name { get; set; }
        public decimal Resitamount { get; set; }
        public decimal Supamount { get; set; }
        public bool Ispercentage { get; set; }

        public virtual Feecategory Feecategory { get; set; }
        public virtual Resitcategory Resitcategory { get; set; }
        public virtual Resittemplate Resittemplate { get; set; }
    }
}

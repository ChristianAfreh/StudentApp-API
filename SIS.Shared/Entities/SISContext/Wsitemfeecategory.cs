using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Wsitemfeecategory
    {
        public Wsitemfeecategory()
        {
            Wsitemfeecategorybankaccounts = new HashSet<Wsitemfeecategorybankaccount>();
        }

        public int Wsitem { get; set; }
        public int Feecategoryid { get; set; }

        public virtual Feecategory Feecategory { get; set; }
        public virtual Wsitem WsitemNavigation { get; set; }
        public virtual ICollection<Wsitemfeecategorybankaccount> Wsitemfeecategorybankaccounts { get; set; }
    }
}

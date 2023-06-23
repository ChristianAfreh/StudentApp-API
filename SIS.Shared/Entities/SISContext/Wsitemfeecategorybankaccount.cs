using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Wsitemfeecategorybankaccount
    {
        public int Wsitem { get; set; }
        public int Feecategoryid { get; set; }
        public int Bankaccountid { get; set; }

        public virtual Bankaccount Bankaccount { get; set; }
        public virtual Wsitemfeecategory Wsitemfeecategory { get; set; }
    }
}

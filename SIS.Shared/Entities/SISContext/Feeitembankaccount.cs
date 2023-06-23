using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Feeitembankaccount
    {
        public int Feeitemid { get; set; }
        public int Bankid { get; set; }
        public int Bankaccountid { get; set; }
        public bool Isactive { get; set; }
    }
}

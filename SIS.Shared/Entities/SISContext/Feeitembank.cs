﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Feeitembank
    {
        public int Feeitemid { get; set; }
        public int Bankid { get; set; }
        public bool Isactive { get; set; }
    }
}

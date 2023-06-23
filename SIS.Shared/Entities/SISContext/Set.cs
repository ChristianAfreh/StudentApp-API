﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Set
    {
        public string Key { get; set; }
        public double Score { get; set; }
        public string Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Feerequirement
    {
        public int Id { get; set; }
        public int Feegroupid { get; set; }
        public double? Minpercent { get; set; }
    }
}

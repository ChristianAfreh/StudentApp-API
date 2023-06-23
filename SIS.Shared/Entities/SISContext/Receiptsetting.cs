using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Receiptsetting
    {
        public int Id { get; set; }
        public int Seed { get; set; }
        public int Increment { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
    }
}

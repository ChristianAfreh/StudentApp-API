using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Denomination
    {
        public int Denominationid { get; set; }
        public string Name { get; set; }
        public bool? Ischristian { get; set; }
        public string Shortname { get; set; }
        public short Sortcol { get; set; }
    }
}

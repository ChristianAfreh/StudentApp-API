using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TempStudent
    {
        public string Indexno { get; set; }
        public int? Psid { get; set; }
        public int? Yr { get; set; }
        public int? Optionid { get; set; }
    }
}

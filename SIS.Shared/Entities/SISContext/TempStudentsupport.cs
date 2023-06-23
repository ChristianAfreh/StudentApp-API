using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TempStudentsupport
    {
        public string Studentid { get; set; }
        public string Support { get; set; }
        public string Type { get; set; }
        public int? Acadyear { get; set; }
    }
}

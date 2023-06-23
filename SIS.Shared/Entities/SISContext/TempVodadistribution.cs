using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TempVodadistribution
    {
        public string Studentid { get; set; }
        public string Schoolmobile { get; set; }
        public DateTime? Dateissued { get; set; }
        public int? Dmonth { get; set; }
    }
}

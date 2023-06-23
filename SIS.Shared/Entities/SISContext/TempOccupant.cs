using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TempOccupant
    {
        public string Stno { get; set; }
        public string Surname { get; set; }
        public string Othername { get; set; }
        public string Residence { get; set; }
        public string Roomno { get; set; }
        public int? Residenceid { get; set; }
    }
}

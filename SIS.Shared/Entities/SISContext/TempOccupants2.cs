using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TempOccupants2
    {
        public string Stno { get; set; }
        public string Surname { get; set; }
        public string Othername { get; set; }
        public int? AltResidenceId { get; set; }
        public string Residence { get; set; }
        public string Roomno { get; set; }
        public DateTime? DateAdded { get; set; }
        public string IsReservedRoom { get; set; }
    }
}

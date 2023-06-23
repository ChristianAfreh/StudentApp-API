using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TempKenCtm
    {
        public int Id { get; set; }
        public string Studentid { get; set; }
        public string Name { get; set; }
        public string Programmestream { get; set; }
        public string Year { get; set; }
        public string Reportedsystembal { get; set; }
        public string Reportedactualbal { get; set; }
    }
}

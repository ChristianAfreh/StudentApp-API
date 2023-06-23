using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Residencesetting
    {
        public int Id { get; set; }
        public int? Acadyear { get; set; }
        public int? Reservedbedspergender { get; set; }
        public int? Bedsreserved { get; set; }
    }
}

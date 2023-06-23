using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Feethresholdprogrammestream
    {
        public int Id { get; set; }
        public decimal? Thresholdvalue { get; set; }
        public int Programmestreamid { get; set; }
        public int Sem { get; set; }
    }
}

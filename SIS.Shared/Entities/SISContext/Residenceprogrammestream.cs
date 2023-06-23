using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Residenceprogrammestream
    {
        public int Id { get; set; }
        public int Residenceid { get; set; }
        public int Programmestreamid { get; set; }
    }
}

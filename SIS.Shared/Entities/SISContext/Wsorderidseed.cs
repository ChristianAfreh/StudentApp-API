using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Wsorderidseed
    {
        public int Id { get; set; }
        public DateTime Transdate { get; set; }
        public int Seed { get; set; }
    }
}

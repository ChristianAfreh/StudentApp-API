using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Residencequotalog
    {
        public int Id { get; set; }
        public string Residence { get; set; }
        public string Gender { get; set; }
        public int Oldvalue { get; set; }
        public int Newvalue { get; set; }
        public DateTime Actiontime { get; set; }
        public string Actiontaken { get; set; }
        public string Username { get; set; }
    }
}

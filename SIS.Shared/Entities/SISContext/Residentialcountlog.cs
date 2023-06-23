using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Residentialcountlog
    {
        public int Id { get; set; }
        public string Residence { get; set; }
        public string Gender { get; set; }
        public int? Number { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Username { get; set; }
    }
}

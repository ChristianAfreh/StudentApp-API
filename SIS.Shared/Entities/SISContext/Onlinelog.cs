using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Onlinelog
    {
        public string Username { get; set; }
        public DateTime Actiondate { get; set; }
        public string Actiontaken { get; set; }
        public string App { get; set; }
        public int? Appversion { get; set; }
    }
}

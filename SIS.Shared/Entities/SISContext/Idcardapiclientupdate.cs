using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Idcardapiclientupdate
    {
        public int Id { get; set; }
        public string Clientid { get; set; }
        public string Clienttype { get; set; }
        public string Phone { get; set; }
        public string Maskedpan { get; set; }
        public DateTime? Timeactivated { get; set; }
        public DateTime? Timeinserted { get; set; }
    }
}

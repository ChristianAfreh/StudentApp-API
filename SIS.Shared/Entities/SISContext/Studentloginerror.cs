using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentloginerror
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Remark { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string App { get; set; }
    }
}

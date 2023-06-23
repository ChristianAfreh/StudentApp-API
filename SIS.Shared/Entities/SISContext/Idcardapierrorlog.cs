using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Idcardapierrorlog
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public DateTime? Timeinserted { get; set; }
    }
}

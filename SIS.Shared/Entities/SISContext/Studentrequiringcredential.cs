using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentrequiringcredential
    {
        public int Id { get; set; }
        public string Studentid { get; set; }
        public bool Isqueued { get; set; }
        public DateTime Timeinserted { get; set; }
    }
}

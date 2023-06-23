using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TempKenDo
    {
        public DateTime Timestamp { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Programme { get; set; }
        public string Studentid { get; set; }
        public string Proofofsubmission { get; set; }
        public string Otherconcerns { get; set; }
    }
}

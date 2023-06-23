using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Residentialbilllog
    {
        public int Id { get; set; }
        public string Studentid { get; set; }
        public int Acadyear { get; set; }
        public bool Issuccessful { get; set; }
        public string Comment { get; set; }
        public DateTime Datetimeinserted { get; set; }
        public string Insertedby { get; set; }
        public string Actiontaken { get; set; }
    }
}

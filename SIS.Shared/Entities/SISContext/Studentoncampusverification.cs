using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentoncampusverification
    {
        public string Studentid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public string Clientnetaddress { get; set; }

        public virtual Semester Semester { get; set; }
        public virtual Student Student { get; set; }
    }
}

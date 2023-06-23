using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewTaggedstudent
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public string Programmestream { get; set; }
        public string Acadyear { get; set; }
        public int Sem { get; set; }
        public int Tagid { get; set; }
        public string Tag { get; set; }
        public string Reason { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Insertedby { get; set; }
    }
}

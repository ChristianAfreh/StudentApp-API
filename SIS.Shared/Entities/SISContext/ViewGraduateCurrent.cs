using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewGraduateCurrent
    {
        public Guid Graduationstreamid { get; set; }
        public string College { get; set; }
        public string Studentid { get; set; }
        public string Indexno { get; set; }
        public int Programmestreamid { get; set; }
        public string Shortprogrammename { get; set; }
        public string Longprogrammename { get; set; }
        public string Specialization { get; set; }
        public DateTime Effectivedate { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Viewstudentprogramme
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Optionid { get; set; }
        public string Indexno { get; set; }
        public bool? Isfeepaying { get; set; }
        public int? Campusid { get; set; }
        public bool Isresidential { get; set; }
    }
}

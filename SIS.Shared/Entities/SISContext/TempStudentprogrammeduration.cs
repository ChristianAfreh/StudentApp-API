using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TempStudentprogrammeduration
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public string Programme { get; set; }
        public int? Yearlevel { get; set; }
        public int? Acadyearenrolled { get; set; }
        public int? Duration { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Viewdistinctprogrammecourselecturer
    {
        public int Programmestreamid { get; set; }
        public string Programme { get; set; }
        public int? Lecturerid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
    }
}

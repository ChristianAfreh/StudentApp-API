using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Viewprogrammecourselecturer
    {
        public string Programme { get; set; }
        public string Coursecode { get; set; }
        public int? Lecturerid { get; set; }
        public int Acadyear { get; set; }
        public int Acadlevelid { get; set; }
        public int Sem { get; set; }
    }
}

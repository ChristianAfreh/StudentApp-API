using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Viewdistinctprogrammecoursecodelecturer
    {
        public string Coursecode { get; set; }
        public string Coursename { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int? Lecturerid { get; set; }
    }
}

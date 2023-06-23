using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Viewlecturercourse
    {
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Yr { get; set; }
        public int Programmestreamid { get; set; }
        public string Programme { get; set; }
        public int Optionid { get; set; }
        public string Programmeoption { get; set; }
        public string Coursecode { get; set; }
        public string Coursename { get; set; }
        public long? Staffid { get; set; }
        public string Lecturer { get; set; }
    }
}

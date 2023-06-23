using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Viewcourse
    {
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Acadlevelid { get; set; }
        public string Coursecode { get; set; }
        public int Coursetypeid { get; set; }
        public int? Electivesetid { get; set; }
        public string Coursename { get; set; }
        public int Credit { get; set; }
        public int Optionid { get; set; }
    }
}

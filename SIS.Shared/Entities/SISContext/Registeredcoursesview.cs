using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Registeredcoursesview
    {
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Acadlevelid { get; set; }
        public string Coursecode { get; set; }
        public string Coursename { get; set; }
        public int Credit { get; set; }
        public double? Totalmark { get; set; }
        public string Grade { get; set; }
        public string Programme { get; set; }
    }
}

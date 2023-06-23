using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewAcademicrecord
    {
        public int Id { get; set; }
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Coursecode { get; set; }
        public int Acadlevelid { get; set; }
        public string Coursename { get; set; }
        public int Credit { get; set; }
    }
}

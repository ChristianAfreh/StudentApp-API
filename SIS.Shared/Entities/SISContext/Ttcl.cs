using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Ttcl
    {
        public int Clid { get; set; }
        public int? Countstudent { get; set; }
        public string Coursecode { get; set; }
        public int? Lecturerid { get; set; }
        public Guid? Groupid { get; set; }
    }
}

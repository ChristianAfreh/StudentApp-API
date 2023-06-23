using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Ttcourselecturerprogrammestreamgroup
    {
        public string Coursecode { get; set; }
        public int Lecturerid { get; set; }
        public int Programmestreamid { get; set; }
        public int Optionid { get; set; }
        public int Countstudent { get; set; }
        public Guid? Groupid { get; set; }
    }
}

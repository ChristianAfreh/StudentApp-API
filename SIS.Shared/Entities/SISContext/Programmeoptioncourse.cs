﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Programmeoptioncourse
    {
        public int Optionid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Acadlevelid { get; set; }
        public string Coursecode { get; set; }
        public int? Electivesetid { get; set; }
        public int? Lecturerid { get; set; }
        public bool Isexemptresultcheck { get; set; }

        public virtual Courselecturer Courselecturer { get; set; }
        public virtual Electiveset Electiveset { get; set; }
        public virtual Programmeoption Programmeoption { get; set; }
        public virtual Semester Semester { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class Assessmentavgcat
    {
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Staffid { get; set; }
        public int Setid { get; set; }
        public string Coursecode { get; set; }
        public int Categoryid { get; set; }
        public string Category { get; set; }
        public string Qrange { get; set; }
        public bool? Includeingrand { get; set; }
        public int? _1 { get; set; }
        public int? _2 { get; set; }
        public int? _3 { get; set; }
        public int? _4 { get; set; }
        public int? _5 { get; set; }
        public int? T { get; set; }
        public decimal? A { get; set; }
    }
}
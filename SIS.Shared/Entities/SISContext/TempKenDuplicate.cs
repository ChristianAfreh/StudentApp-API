using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TempKenDuplicate
    {
        public int? Studentid { get; set; }
        public string Indexno { get; set; }
        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Programmestream { get; set; }
        public string Year { get; set; }
        public string Acadyear { get; set; }
        public double? Admissionyear { get; set; }
        public string Studenttag { get; set; }
        public string Tt { get; set; }
    }
}

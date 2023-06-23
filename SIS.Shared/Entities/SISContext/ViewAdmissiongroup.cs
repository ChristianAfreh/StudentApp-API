using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewAdmissiongroup
    {
        public int Admissiongroupid { get; set; }
        public string Name { get; set; }
        public int Graduatetypeid { get; set; }
        public int? Feecategoryid { get; set; }
        public bool Isinternational { get; set; }
        public bool Isactive { get; set; }
        public int? Admissionstreamid { get; set; }
        public bool Canselectcampus { get; set; }
        public int? Campuschoicecount { get; set; }
        public int? Campusid { get; set; }
        public string Mappingcode { get; set; }
        public int? Acadyear { get; set; }
        public int? Programmechoicecount { get; set; }
    }
}

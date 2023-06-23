using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewApplicantadmitted
    {
        public string Applicantid { get; set; }
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Admissionlevelid { get; set; }
        public int? Optionid { get; set; }
        public int Admissionoffercategoryid { get; set; }
        public int? Aggregateobtained { get; set; }
        public bool Autoadmitted { get; set; }
        public int Isaccepted { get; set; }
        public int? Residenceid { get; set; }
        public DateTime? Timeinserted { get; set; }
        public int? Lecturesessionid { get; set; }
        public int? Monthid { get; set; }
        public int? Feecategoryid { get; set; }
        public int? Campusid { get; set; }
        public string Insertedby { get; set; }
        public DateTime? Timeaccepted { get; set; }
        public string Remarks { get; set; }
        public bool Canview { get; set; }
        public bool Canprint { get; set; }
        public int Acadyearenrolled { get; set; }
        public int Semenrolled { get; set; }
        public bool Cansenddata { get; set; }
        public int Id { get; set; }
    }
}

using System;
namespace SIS.Shared.Entities.SISContext
{
    public class StudentDetail
    {
        public string STUDENTID { get; set; }
        public byte[] PHOTO { get; set; }
        public string SCHOOLEMAIL { get; set; }
        public string INDEXNO { get; set; }
        public string SURNAME { get; set; }
        public string OTHERNAME { get; set; }
        public DateTime? BIRTHDATE { get; set; }
        public string FULLNAME { get; set; }
        public int? TITLEID { get; set; }
        public string TITLE { get; set; }
        public string GENDER { get; set; }
        public int? MARITALSTATUSID { get; set; }
        public string MARITALSTATUS { get; set; }
        public bool? ISINCURRENTSEM { get; set; }
        public bool? HASGRADUATED { get; set; }
        public bool? ISFRESHER { get; set; }
        public string COUNTRY { get; set; }
        public string CAMPUS { get; set; }
        public int? REGIONID { get; set; }
        public string REGION { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string PRIMARYMOBILE { get; set; }
        public string SCHOOLMOBILE { get; set; }
        public string RESADD1 { get; set; }
        public string RESADD2 { get; set; }
        public string RESADD3 { get; set; }
        public string RESADD4 { get; set; }
        public string POSTADD1 { get; set; }
        public string POSTADD2 { get; set; }
        public string POSTADD3 { get; set; }
        public string POSTADD4 { get; set; }
        public string PASSPORTNO { get; set; }
        public int PROGRAMMESTREAMID { get; set; }
        public string PROGRAMMESTREAM { get; set; }
        public string PROGRAMMEOPTION { get; set; }
        public int? ACADYEAR { get; set; }
        public string ACADYEARSTRING { get; set; }
        public int? SEM { get; set; }
        public int? YR { get; set; }
        public string YRSTRING { get; set; }
        public bool ISRESIDENTIAL { get; set; }
        public bool? ISFEEPAYING { get; set; }
        public int? DEPARTMENTID { get; set; }
        public int? FACULTYID { get; set; }
        public int? COLLEGEID { get; set; }
        public string DEPARTMENT { get; set; }
        public string FACULTY { get; set; }
        public string COLLEGE { get; set; }
        public bool? ISEMAILCONFIRMED { get; set; }
        public bool? ISVERIFICATIONEMAILSENT { get; set; }
        public string FEECATEGORY { get; set; }
        public int? RELIGIONID { get; set; }
        public string RELIGIONNAME { get; set; }
        public int? DENOMINATIONID { get; set; }
        public string DENOMINATIONNAME { get; set; }
        public string LINKEDINURL { get; set; }
    }
}

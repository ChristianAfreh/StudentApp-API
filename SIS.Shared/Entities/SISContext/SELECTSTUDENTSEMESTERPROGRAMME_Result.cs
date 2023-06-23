using System;
namespace SIS.Shared.Entities.SISContext
{
    public partial class SELECTSTUDENTSEMESTERPROGRAMME_Result
    {
        public string STUDENTID { get; set; }
        public decimal? FEESPAID { get; set; }
        public int PROGRAMMESTREAMID { get; set; }
        public int OPTIONID { get; set; }
        public string INDEXNO { get; set; }
        public bool? ISFEEPAYING { get; set; }
        public int? CAMPUSID { get; set; }
        public bool ISRESIDENTIAL { get; set; }
        public string OPTIONNAME { get; set; }
        public int FINALYEAR { get; set; }
        public int FINALSEM { get; set; }
        public string PROGRAMMENAME { get; set; }
        public int? FACULTYID { get; set; }
        public bool BIOMETRICVERIFICATIONREQUIRED { get; set; }
        public int PROGRAMMEID { get; set; }
        public int TIMESTREAMID { get; set; }
        public int ACADLEVELID { get; set; }
        public bool? ISVERIFIED { get; set; }
        public string FEECATEGORY { get; set; }
    }
}

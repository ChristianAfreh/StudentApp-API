using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class StudentBk
    {
        public string Studentid { get; set; }
        public string Surname { get; set; }
        public string Othername { get; set; }
        public int? Titleid { get; set; }
        public string Gender { get; set; }
        public byte[] Picture { get; set; }
        public string Countryid { get; set; }
        public string Birthcountryid { get; set; }
        public string Rescountryid { get; set; }
        public int? Regionid { get; set; }
        public int? Resregionid { get; set; }
        public DateTime? Birthdate { get; set; }
        public int? Residenceid { get; set; }
        public bool Isforeigner { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Ssn { get; set; }
        public string Resadd1 { get; set; }
        public string Resadd2 { get; set; }
        public string Resadd3 { get; set; }
        public string Resadd4 { get; set; }
        public string Postadd1 { get; set; }
        public string Postadd2 { get; set; }
        public string Postadd3 { get; set; }
        public string Postadd4 { get; set; }
        public string Passportno { get; set; }
        public string Guardianname { get; set; }
        public string Guardianrelationship { get; set; }
        public string Guardianaddress { get; set; }
        public string Guardianoccupation { get; set; }
        public string Guardianphone { get; set; }
        public string Guardianemail { get; set; }
        public string Schoolemail { get; set; }
        public string Schoolpwd { get; set; }
        public int? Maritalstatusid { get; set; }
        public int? Sourceid { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public bool Islocked { get; set; }
        public string Phonecountrycode { get; set; }
        public string Primarymobile { get; set; }
        public string Schoolmobile { get; set; }
        public string Schoolmobileserialno { get; set; }
        public int? Acadyearenrolled { get; set; }
        public string Affiliateid { get; set; }
        public Guid? Sourcerowid { get; set; }
        public bool? Logincreated { get; set; }
        public string Logincreateerror { get; set; }
        public int? Religionid { get; set; }
        public int? Placeofresidenceid { get; set; }
        public int? Delme { get; set; }
        public string Birthtown { get; set; }
        public bool? Isdisabled { get; set; }
        public string Disability { get; set; }
        public int? Denominationid { get; set; }
        public string Denomination { get; set; }
        public int? Currentresidenceid { get; set; }
        public Guid? Sourcerowguid { get; set; }
        public bool Islessendowed { get; set; }
        public int? Programmestreamid { get; set; }
    }
}

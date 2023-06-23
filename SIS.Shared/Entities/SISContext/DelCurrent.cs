using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class DelCurrent
    {
        public string Studentid { get; set; }
        public string Surname { get; set; }
        public string Othername { get; set; }
        public string Fullname { get; set; }
        public string Schoolmobile { get; set; }
        public string Primarymobile { get; set; }
        public string Gender { get; set; }
        public string Programmestream { get; set; }
        public int Acadlevelid { get; set; }
        public int Sem { get; set; }
        public int Acadyear { get; set; }
        public string Acadyearstring { get; set; }
        public int? Departmentid { get; set; }
        public string Department { get; set; }
        public int? Facultyid { get; set; }
        public string Faculty { get; set; }
        public int? Collegeid { get; set; }
        public string College { get; set; }
        public int? Tagid { get; set; }
        public string Tag { get; set; }
        public int Graduatetypeid { get; set; }
        public string Graduatetype { get; set; }
        public bool ProgrammestreamBiometricverificationrequired { get; set; }
        public int Isbiometricallyverified { get; set; }
        public int Iscourseregistered { get; set; }
        public int IsbiometricallyOrCourseregistered { get; set; }
        public int? Campusid { get; set; }
        public string Campus { get; set; }
        public int Isghanaian { get; set; }
        public bool Isforeigner { get; set; }
        public int? Feecategoryid { get; set; }
        public string Feecategory { get; set; }
        public int Isingraceperiod { get; set; }
        public int Isinfinalyear { get; set; }
        public string Studentcategoryname { get; set; }
    }
}

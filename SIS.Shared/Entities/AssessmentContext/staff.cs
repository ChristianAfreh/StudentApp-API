using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.AssessmentContext
{
    public partial class staff
    {
        public string Staffid { get; set; }
        public string Filenumber { get; set; }
        public string Surname { get; set; }
        public string Othername { get; set; }
        public string Maidenname { get; set; }
        public string Gender { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Techmail { get; set; }
        public int Titleid { get; set; }
        public int Departmentid { get; set; }
        public int Employmenttypeid { get; set; }
        public int? Sectionid { get; set; }
        public bool Isactive { get; set; }
        public bool Isdeleted { get; set; }
        public DateTime? Employmentenddate { get; set; }
        public string Knustvodafoneno { get; set; }
        public string Knustvodaserialno { get; set; }
        public int Newstaffid { get; set; }
        public string Email { get; set; }
    }
}

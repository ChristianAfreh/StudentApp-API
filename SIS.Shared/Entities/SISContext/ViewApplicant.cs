using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewApplicant
    {
        public string Applicantid { get; set; }
        public int Admissiongroupid { get; set; }
        public int? Applicationtypeid { get; set; }
        public int? Admissionstatusid { get; set; }
        public int Acadyear { get; set; }
        public int? Envelopeserialno { get; set; }
        public string Envelopeno { get; set; }
        public int? Maritalstatusid { get; set; }
        public string Countryid { get; set; }
        public int? Homeregionid { get; set; }
        public int? Resregionid { get; set; }
        public string Disabilitydetails { get; set; }
        public int? Diabilityid { get; set; }
        public bool Isdisabled { get; set; }
        public int? Titleid { get; set; }
        public string Surname { get; set; }
        public string Othername { get; set; }
        public string Firstname { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Birthplace { get; set; }
        public string Resadd1 { get; set; }
        public string Resadd2 { get; set; }
        public string Resadd3 { get; set; }
        public string Resadd4 { get; set; }
        public string Postadd1 { get; set; }
        public string Postadd2 { get; set; }
        public string Postadd3 { get; set; }
        public string Postadd4 { get; set; }
        public string Email { get; set; }
        public string Phonecountryid { get; set; }
        public string Phone { get; set; }
        public string Sponsorname { get; set; }
        public string Sponsoradd1 { get; set; }
        public string Sponsoradd2 { get; set; }
        public string Sponsoradd3 { get; set; }
        public string Sponsoradd4 { get; set; }
        public string Sponsorphone { get; set; }
        public string Sponsoremail { get; set; }
        public bool? Isbonded { get; set; }
        public string Bondorganisation { get; set; }
        public DateTime? Bondexpirydate { get; set; }
        public bool? Isresultverified { get; set; }
        public string Paymenttypeno { get; set; }
        public bool? Isstaffdevelopment { get; set; }
        public bool? Isstaff { get; set; }
        public bool Isstaffchild { get; set; }
        public bool Islessendowed { get; set; }
        public string Nextofkin { get; set; }
        public string Nextofkinadd1 { get; set; }
        public string Nextofkinadd2 { get; set; }
        public string Nextofkinadd3 { get; set; }
        public string Nextofkinadd4 { get; set; }
        public string Workexperience { get; set; }
        public int? Workexperienceinyears { get; set; }
        public int? Religionid { get; set; }
        public string Religion { get; set; }
        public string Hometown { get; set; }
        public string Presentoccupation { get; set; }
        public string Workplace { get; set; }
        public bool Isresidential { get; set; }
        public bool? Isdisqualified { get; set; }
        public int? Residenceid { get; set; }
        public bool Infocertifiedbyapplicant { get; set; }
        public bool? Passedengmath { get; set; }
        public int? Laststep { get; set; }
        public int? Bestaggregate { get; set; }
        public bool Issubmitted { get; set; }
        public DateTime? Timesubmitted { get; set; }
        public int? Interviewscore { get; set; }
        public int? Entranceexamscore { get; set; }
        public DateTime? Timeinserted { get; set; }
        public DateTime? Timeupdated { get; set; }
        public string Insertedby { get; set; }
        public string Updatedby { get; set; }
        public int Dobday { get; set; }
        public int Dobmonth { get; set; }
        public int Dobyear { get; set; }
        public bool Consider4feepaying { get; set; }
        public bool Consider4parallel { get; set; }
        public int? Admissionlevelid { get; set; }
        public int? Applicationmodeid { get; set; }
    }
}

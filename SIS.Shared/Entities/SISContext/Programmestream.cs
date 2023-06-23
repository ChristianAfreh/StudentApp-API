using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Programmestream
    {
        public Programmestream()
        {
            Alumnidetails = new HashSet<Alumnidetail>();
            ClassparameterBks = new HashSet<ClassparameterBk>();
            Classparameters = new HashSet<Classparameter>();
            Courseregistrationexceptions = new HashSet<Courseregistrationexception>();
            Feeschedules = new HashSet<Feeschedule>();
            Programmecourses = new HashSet<Programmecourse>();
            Programmeoptions = new HashSet<Programmeoption>();
            Programmesemesters = new HashSet<Programmesemester>();
            Programmestreamgroupdetails = new HashSet<Programmestreamgroupdetail>();
            Studentfeeclearances = new HashSet<Studentfeeclearance>();
            Studentprogrammes = new HashSet<Studentprogramme>();
        }

        public int Programmestreamid { get; set; }
        public int Programmeid { get; set; }
        public int Timestreamid { get; set; }
        public int Finalyear { get; set; }
        public int Finalsem { get; set; }
        public bool? Addoptiontocert { get; set; }
        public string Name { get; set; }
        public string Reporttitle { get; set; }
        public int? Gradingid { get; set; }
        public bool? Isadmissionavailable { get; set; }
        public int? Calendarid { get; set; }
        public int? Mincredits { get; set; }
        public string CtLine1 { get; set; }
        public string CtLine2 { get; set; }
        public string CtLine3 { get; set; }
        public string CtLine4 { get; set; }
        public string CtcLine1 { get; set; }
        public string CtcLine2 { get; set; }
        public string CtcLine3 { get; set; }
        public string CtcLine4 { get; set; }
        public string CrLine1 { get; set; }
        public string CrLine2 { get; set; }
        public string CrLine3 { get; set; }
        public string CrLine4 { get; set; }
        public string Governingboard { get; set; }
        public string Transcriptourrefprefix { get; set; }
        public string Durationdescription { get; set; }
        public int? Coresetid { get; set; }
        public int? Departmentid { get; set; }
        public int? Parentdepartmentid { get; set; }
        public int? Affiliateddepartmenttid { get; set; }
        public int? Facultyid { get; set; }
        public int? Parentfacultyid { get; set; }
        public int? Collegeid { get; set; }
        public int? Parentcollegeid { get; set; }
        public int? Sourceid { get; set; }
        public int? Feeclassificationid { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public bool? Biometricverificationrequired { get; set; }
        public bool? Isactive { get; set; }
        public int? Wsitemid { get; set; }
        public int? Resitcategoryid { get; set; }
        public int? Resittemplateid { get; set; }
        public string Streamcode { get; set; }

        public virtual Department Affiliateddepartmentt { get; set; }
        public virtual Calendar Calendar { get; set; }
        public virtual College College { get; set; }
        public virtual Department Department { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual Gradingsystem Grading { get; set; }
        public virtual Programme Programme { get; set; }
        public virtual Resitcategory Resitcategory { get; set; }
        public virtual Resittemplate Resittemplate { get; set; }
        public virtual Timestream Timestream { get; set; }
        public virtual Wsitem Wsitem { get; set; }
        public virtual ICollection<Alumnidetail> Alumnidetails { get; set; }
        public virtual ICollection<ClassparameterBk> ClassparameterBks { get; set; }
        public virtual ICollection<Classparameter> Classparameters { get; set; }
        public virtual ICollection<Courseregistrationexception> Courseregistrationexceptions { get; set; }
        public virtual ICollection<Feeschedule> Feeschedules { get; set; }
        public virtual ICollection<Programmecourse> Programmecourses { get; set; }
        public virtual ICollection<Programmeoption> Programmeoptions { get; set; }
        public virtual ICollection<Programmesemester> Programmesemesters { get; set; }
        public virtual ICollection<Programmestreamgroupdetail> Programmestreamgroupdetails { get; set; }
        public virtual ICollection<Studentfeeclearance> Studentfeeclearances { get; set; }
        public virtual ICollection<Studentprogramme> Studentprogrammes { get; set; }
    }
}

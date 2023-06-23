using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Viewstaffappsgetcoursedetail
    {
        public string Studentid { get; set; }
        public string Indexno { get; set; }
        public int Programmestreamid { get; set; }
        public string Programme { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Acadlevelid { get; set; }
        public string Coursecode { get; set; }
        public string Coursename { get; set; }
        public int Credit { get; set; }
        public int? Coursestatusid { get; set; }
        public string Coursestatuscode { get; set; }
        public double? Endsemmark { get; set; }
        public double? Totalmark { get; set; }
        public string Oldmark { get; set; }
        public double? Numeq { get; set; }
        public string Grade { get; set; }
        public string Name { get; set; }
        public double? Camark { get; set; }
        public int Id { get; set; }
        public int Optionid { get; set; }
        public string Optionname { get; set; }
        public string Updatedby { get; set; }
        public DateTime? Timeupdated { get; set; }
        public int? Lecturerid { get; set; }
    }
}

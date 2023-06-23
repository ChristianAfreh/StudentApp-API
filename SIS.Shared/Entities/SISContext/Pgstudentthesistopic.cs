using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Pgstudentthesistopic
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public string Thesistopic { get; set; }
        public int Id { get; set; }
        public DateTime? Effectivedate { get; set; }
        public string Insertedby { get; set; }
        public string Updatedby { get; set; }
        public DateTime? Timeupdated { get; set; }
        public bool? Thesisstatus { get; set; }
        public DateTime? Timeinserted { get; set; }
        public bool Passedoralexam { get; set; }

        public virtual Studentprogramme Studentprogramme { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentfeecategory
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Feecategoryid { get; set; }
        public int? Sourceid { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public Guid? Sourcerowguid { get; set; }
        public string Comment { get; set; }
        public DateTime? Timeupdated { get; set; }

        public virtual Feecategory Feecategory { get; set; }
        public virtual Studentsemester Studentsemester { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentsemester20220218
    {
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int Acadlevelid { get; set; }
        public bool? Autopromoted { get; set; }
        public int? Sourceid { get; set; }
        public DateTime? Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public int? Preregistrationstatus { get; set; }
        public bool Iscurrent { get; set; }
        public Guid? Sourcerowguid { get; set; }
        public Guid Id { get; set; }
        public string Metadata { get; set; }
        public int? Yr2 { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentfeeexemption
    {
        public Guid Id { get; set; }
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Currencyid { get; set; }
        public double Amount { get; set; }
        public double Xrate { get; set; }
        public string Reason { get; set; }
        public DateTime Transdate { get; set; }
        public DateTime Timeinserted { get; set; }
        public string Insertedby { get; set; }
        public double? Xrate2 { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual Studentsemester Studentsemester { get; set; }
    }
}

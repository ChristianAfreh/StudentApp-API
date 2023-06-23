using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentrefund
    {
        public Guid Id { get; set; }
        public string Receiptno { get; set; }
        public string Studentid { get; set; }
        public int Programmestreamid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public DateTime Transdate { get; set; }
        public string Currencyid { get; set; }
        public double? Amount { get; set; }
        public double Xrate { get; set; }
        public DateTime Timeinserted { get; set; }
        public DateTime? Timeupdated { get; set; }
        public string Insertedby { get; set; }
        public string Updatedby { get; set; }
        public double? Xrate2 { get; set; }
        public int Refundtypeid { get; set; }
        public string Importbatchid { get; set; }
        public string Foliono { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual Refundtype Refundtype { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual Studentsemester Studentsemester { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewStudentbiometricverification
    {
        public string Studentid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public DateTime? Timeinserted { get; set; }
    }
}

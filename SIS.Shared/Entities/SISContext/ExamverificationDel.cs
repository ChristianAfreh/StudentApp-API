using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ExamverificationDel
    {
        public int Examverificationid { get; set; }
        public string Studentid { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Coursecode { get; set; }
        public bool? Isverifiedmidsem { get; set; }
        public bool? Isverifiedmidsemmanually { get; set; }
        public DateTime? Isverifiedmidsemat { get; set; }
        public string Isverifiedmidsemby { get; set; }
        public bool? Isinsemmidsem { get; set; }
        public bool? Isverifiedendsem { get; set; }
        public bool? Isverifiedendsemmanually { get; set; }
        public DateTime? Isverifiedendsemat { get; set; }
        public string Isverifiedendsemby { get; set; }
        public bool? Isinsemendsem { get; set; }
    }
}

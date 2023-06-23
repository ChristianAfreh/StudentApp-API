using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Delme
    {
        public string Studentid { get; set; }
        public string Surname { get; set; }
        public string Othername { get; set; }
        public string Indexno { get; set; }
        public DateTime? Isverifiedmidsemat { get; set; }
        public string Isverifiedmidsemby { get; set; }
        public int Iscourseregistered { get; set; }
        public int Sortno1 { get; set; }
        public bool? Isinsemmidsem { get; set; }
        public int Sortno2 { get; set; }
        public int Sortno3 { get; set; }
        public string Tag { get; set; }
        public int Sortno4 { get; set; }
        public int Groupcode { get; set; }
        public string Programmestream { get; set; }
    }
}

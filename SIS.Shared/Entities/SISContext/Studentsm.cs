using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentsm
    {
        public int Messageid { get; set; }
        public Guid? Smsid { get; set; }
        public string Studentid { get; set; }
        public int Smscategoryid { get; set; }
        public string Mobileno { get; set; }
        public string Msg { get; set; }
        public DateTime Timesent { get; set; }
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public int? Msgresponsestatus { get; set; }
        public string Messagedeliverystatus { get; set; }
        public string Senderid { get; set; }
        public int? Messagecount { get; set; }
        public int? Messagelength { get; set; }
        public int Isflagged { get; set; }

        public virtual Smscategoryid Smscategory { get; set; }
        public virtual Student Student { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Feedback
    {
        public Guid Id { get; set; }
        public string Studentid { get; set; }
        public string Feedbackmessage { get; set; }
        public DateTime Datetimeinserted { get; set; }
        public string App { get; set; }
    }
}

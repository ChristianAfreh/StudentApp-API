using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Studentemailverification
    {
        public string StudentId { get; set; }
        public bool? IsEmailVerificationSent { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class DelStudentregisteredWhileowingMsg2
    {
        public string Studentid { get; set; }
        public string Surname { get; set; }
        public string Othername { get; set; }
        public string Mobile { get; set; }
        public string Primarymobile { get; set; }
        public string Schoolmobile { get; set; }
        public decimal? StudentFeeBalance { get; set; }
        public string Msg { get; set; }
    }
}

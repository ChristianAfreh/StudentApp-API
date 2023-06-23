using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TempTagstdfee
    {
        public string Studentid { get; set; }
        public int? Programmestreamid { get; set; }
        public int? Acadyear { get; set; }
        public int? Sem { get; set; }
        public string Fullname { get; set; }
        public string IsbiometricallyOrCourseregistered { get; set; }
        public int? Feecategoryid { get; set; }
        public double? StudentTotalFeeBalance { get; set; }
        public double? StudentSemFeeBalance { get; set; }
        public double? StudentBill4Acadyear { get; set; }
        public double? StudentFeeStatus { get; set; }
        public int? Isbiometricallyverified { get; set; }
        public int? Iscourseregistered { get; set; }
    }
}

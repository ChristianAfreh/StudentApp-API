using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class TempStudentdebtor
    {
        public string Studentid { get; set; }
        public int? Programmestreamid { get; set; }
        public int? Feecategoryid { get; set; }
        public decimal? Bal { get; set; }
        public string Currencyid { get; set; }
        public string Feecategory { get; set; }
        public string Programme { get; set; }
        public string College { get; set; }
        public string Graduatetype { get; set; }
    }
}

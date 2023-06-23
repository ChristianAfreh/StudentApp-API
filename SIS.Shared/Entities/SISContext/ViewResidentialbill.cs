using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewResidentialbill
    {
        public int Acadyear { get; set; }
        public int Sem { get; set; }
        public string Studentid { get; set; }
        public int? Feetypeid { get; set; }
        public string Feetype { get; set; }
        public int? Residenceid { get; set; }
        public string Residence { get; set; }
        public string Currencyid { get; set; }
        public double Amount { get; set; }
        public DateTime Transdate { get; set; }
        public DateTime Timeinserted { get; set; }
        public Guid Id { get; set; }
    }
}

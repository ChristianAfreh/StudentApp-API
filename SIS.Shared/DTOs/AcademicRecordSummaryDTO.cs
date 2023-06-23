
using System;
namespace SIS.Shared.DTOs
{
    public class AcademicRecordSummaryGetDTO
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public string IndexNo { get; set; }
        public int? ProgrammeStreamId { get; set; }
        public string Programme { get; set; }
        public int AcadYear { get; set; }
        public int Sem { get; set; }
        public int? Yr { get; set; }
        public string Name { get; set; }
        public string Option { get; set; }
        public string Nationality { get; set; }
        public double? SCR { get; set; }
        public double? SCO { get; set; }
        public double? SCC { get; set; }
        public double? SWM { get; set; }
        public double? SWA { get; set; }
        public double? CCR { get; set; }
        public double? CCO { get; set; }
        public double? CCC { get; set; }
        public double? CWM { get; set; }
        public double? CWA { get; set; }
        public int? NoOfTrail { get; set; }
        public string Trail { get; set; }
        public string Tag { get; set; }
    }
}

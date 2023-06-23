using System;
namespace SIS.Shared.DTOs
{
    public class FeeTransactionGetDTO
    {
        public int ProgrammeStreamId { get; set; }
        public int AcadYear { get; set; }
        public int Sem { get; set; }
        public string CurrencyId { get; set; }
        public double Amount { get; set; }
        public double ExtendedAmount { get; set; }
        public double ExchangeRate { get; set; }
        public decimal CBalance { get; set; }
        public DateTime TransDate { get; set; }
        public double TotalAmt { get; set; }
        public string Narrative { get; set; }
        public string TransType { get; set; }
        public string AcadYearString { get; set; }
        public string SemString { get; set; }
        public int AcadLevelId { get; set; }
        public string AcadLevelString { get; set; }
        public bool CanPrintReceipt { get; set; }
        public int? OfId { get; set; }
    }
}

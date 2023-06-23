using System;
namespace SIS.Shared.DTOs
{
    public class FeeSummaryGetDTO
    {
        public string CurrencyId { get; set; }
        public string CurrencySymbol { get; set; }
        public double TotalBill { get; set; }
        public double TotalPayment { get; set; }
        public double TotalRefund { get; set; }
        public double TotalExemption { get; set; }
        public double TotalBalance { get; set; }
        public double SemesterPayment { get; set; }
        public double BalanceBF { get; set; }
    }
}

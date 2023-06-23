using System;
using System.Collections.Generic;

namespace SIS.Shared.DTOs
{
    public class FeeScheduleGetDTO
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string IndexNo { get; set; }
        public int AcadLevelId { get; set; }
        public string ProgrammeStream { get; set; }
        public string FeeCategory { get; set; }
        public double TotalAmount { get; set; }
        public string Message { get; set; }
        public int AcadYear { get; set; }
        public int Sem { get; set; }
        public string AcadYearString { get; set; }
        public string CurrencyId { get; set; }
        public string CurrencySymbol { get; set; }
        public double TotalBill { get; set; }
        public double TotalPayment { get; set; }
        public double TotalRefund { get; set; }
        public double TotalExemption { get; set; }
        public double TotalBalance { get; set; }
        public double? AmountPaid { get; set; }
        public double? AmountPayable { get; set; }
        public double? BalanceBF { get; set; }
        public List<FeeItemGetDTO> FeeItems { get; set; }
        public List<BankGetDTO> Banks { get; set; }
    }
}

using System;
namespace SIS.Shared.DTOs
{
    public class FeeItemGetDTO
    {
        public string ItemName { get; set; }
        public double ItemAmount { get; set; }
    }

    public class GraduationPaymentRecordViewModel
    {
        public Int64 Id { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public int BankId { get; set; }
        public string CurrencyId { get; set; }
        public decimal Amount { get; set; }
        public string FeeItemCode { get; set; }
    }

    public class GraduationPaymentViewModel
    {
        public bool IsPaid { get; set; }
        public decimal AmountLeft { get; set; }
    }
}

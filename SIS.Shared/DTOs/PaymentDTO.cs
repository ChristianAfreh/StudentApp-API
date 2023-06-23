using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.DTOs
{
    public class PaymentAddDTO
    {
        public string StudentId { get; set; }
        public string FeeItem { get; set; }
        public string CurrencyId { get; set; }
        public decimal Amount { get; set; }
        public bool ShowMobileMoney { get; set; } = false;
        public bool ShowCard { get; set; } = false;
        public bool ShowBank { get; set; } = false;
    }


    public class PaymentNotificationGetDTO
    {
        public string CheckOutUrl { get; set; }
    }

    public class PaymentConfirmationDTO
    {
        public int StatusId { get; set; }
        public string TransactionId { get; set; }
        public string PaymentService { get; set; }
        public string FeeItemCode { get; set; }
        public string FeeItemName { get; set; }
        public string CurrencyId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Amount { get; set; }
        public string VerificationMessage { get; set; }
        public string VerificationCode { get; set; }
        public string Channel { get; set; }
        public string PaymentServiceLogoUrl { get; set; }
        public string StatusMessage { get;  set; }
        public bool IsSuccess { get; set; }
    }

    public class StudentPaymentResultDTO
    {
        public int CurrentPage { get; set; }

        public int TotalItems { get; set; }

        public int TotalPages { get; set; }

        public List<UserPaymentGetDTO> Items { get; set; }
    }

    public class UserPaymentGetDTO
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public int? ProgrammeStreamId { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string Narrative { get; set; }
        public string FeeItemCode { get; set; }
        public string FeeItemName { get; set; }
        public DateTime? TransDate { get; set; }
        public string TransactionId { get; set; }
        public string CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public double Amount { get; set; }
        public DateTime TimeInserted { get; set; }
        public bool? IsConfirmed { get; set; }
        public DateTime? TimeConfirmed { get; set; }
        public bool IsReversal { get; set; }
        public string ReversalReason { get; set; }
        public string AltTransactionId { get; set; }
        public string PaymentChannelCode { get; set; }
        public string PaymentChannelName { get; set; }
        public string PaymentService { get; set; }
        public string TransactionStatus { get; set; }
        public int AcadYear { get; set; }
        public int Sem { get; set; }
        public int? AccountReceiptId { get; set; }
        public string PaymentType { get; set; }
        public bool PrintReceiptAllowed { get; set; }
        public bool RetryAllowed { get; set; }
    }
}

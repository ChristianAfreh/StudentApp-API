using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.DTOs
{
    public class WSPaymentGetDTO
    {
        public long Id { get; set; }
        public string StudentId { get; set; }
        public int? ProgrammeStreamId { get; set; }
        public string BranchName { get; set; }
        public string BankName { get; set; }
        public string Narrative { get; set; }
        public int FeeItemName { get; set; }
        public DateTime? TransDate { get; set; }
        public string TransactionId { get; set; }
        public string CurrencyId { get; set; }
        public string CurrencySymbol { get; set; }
        public decimal Amount { get; set; }
        public string ReversedTransactionId { get; set; }
        public string InsertedBy { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsReversal { get; set; }
        public string ReversalReason { get; set; }
        public string AltTransactionId { get; set; }
        public int? PaymentChannelId { get; set; }
        public string PaymentService { get; set; }
        public string TransactionStatus { get; set; }
        public int AcadYear { get; set; }
        public int Sem { get; set; }
        public int? AccountReceiptId { get; set; }
        public string ConfirmedBy { get; set; }
    }
}

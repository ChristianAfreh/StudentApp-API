using System;
namespace SIS.Shared
{
    public class PaymentSettings
    {
        public string WSBankGId { get; set; }
        public string WSUsername { get; set; }
        public string WSPassword { get; set; }
        public string ManillaMerchantId { get; set; }
        public string ManillaApiKey { get; set; }
        public string ManillaCheckOutUrl { get; set; }
        public string PaymentReturnUrl { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SIS.Shared.DTOs
{
    public class ManillaPaymentConfirmationDTO
    {
        public int status { get; set; }
        public string order_id { get; set; }
        public string transaction_id { get; set; }
    }

    public class ManillaPaymentAddDTO
    {
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("cust_firstname")]
        public string CustFirstname { get; set; }

        [JsonPropertyName("cust_lastname")]
        public string CustLastname { get; set; }

        [JsonPropertyName("cust_email")]
        public string CustEmail { get; set; }

        [JsonPropertyName("cust_phone")]
        public string CustPhone { get; set; }

        [JsonPropertyName("cust_address")]
        public string CustAddress { get; set; }

        [JsonPropertyName("cust_zip")]
        public long CustZip { get; set; }

        [JsonPropertyName("cust_city")]
        public string CustCity { get; set; }

        [JsonPropertyName("cust_country")]
        public string CustCountry { get; set; }

        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("services")]
        public ManillaPaymentServiceDTO Services { get; set; }

        [JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        [JsonPropertyName("cancel_url")]
        public string CancelUrl { get; set; }
    }

    public partial class ManillaPaymentGetDTO
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("data")]
        public ManillaPaymentData Data { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; }
    }

    public partial class ManillaPaymentData
    {
        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("countryShortName")]
        public string CountryShortName { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("cust_address")]
        public string CustAddress { get; set; }

        [JsonPropertyName("cust_city")]
        public string CustCity { get; set; }

        [JsonPropertyName("cust_country")]
        public string CustCountry { get; set; }

        [JsonPropertyName("cust_email")]
        public string CustEmail { get; set; }

        [JsonPropertyName("cust_firstname")]
        public string CustFirstname { get; set; }

        [JsonPropertyName("cust_lastname")]
        public string CustLastname { get; set; }

        [JsonPropertyName("cust_phone")]
        public string CustPhone { get; set; }

        [JsonPropertyName("cust_zip")]
        public long CustZip { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }

        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }

    public partial class Item
    {
        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }

    public partial class Links
    {
        [JsonPropertyName("cancel_url")]
        public Uri CancelUrl { get; set; }

        [JsonPropertyName("checkout_url")]
        public Uri CheckoutUrl { get; set; }

        [JsonPropertyName("return_url")]
        public Uri ReturnUrl { get; set; }
    }

    public partial class ManillaPaymentServiceDTO
    {
        [JsonPropertyName("mobile_money")]
        public bool MobileMoney { get; set; }

        [JsonPropertyName("cards")]
        public bool Cards { get; set; }

        [JsonPropertyName("bank")]
        public bool Bank { get; set; }
    }

    public class ManillaResponse
    {
        public string code { get; set; }
        public ManillaResponseData data { get; set; }
        public string msg { get; set; }
    }

    public class ManillaErrorResponse
    {
        public string code { get; set; }
        public List<ManillaResponseData> data { get; set; }
        public string msg { get; set; }
    }

    public class ManillaResponseData
    {
        public double amount { get; set; }
        public string channel { get; set; }
        public string countryShortName { get; set; }
        public string currency { get; set; }
        //public CustomerData customerData { get; set; }
        public string customerId { get; set; }
        public string dateCreated { get; set; }
        //public ExtraDetails extraDetails { get; set; }
        public string id { get; set; }
        public string ip { get; set; }
        public string merchantId { get; set; }
        public string orderId { get; set; }
        public string service { get; set; }
        public string status { get; set; }
        public string transactionId { get; set; }
    }
    public class ManillaServiceType
    {
        [Key]
        public string code { get; set; }
        public string Name { get; set; }
        public string IconName { get; set; }

    }

}

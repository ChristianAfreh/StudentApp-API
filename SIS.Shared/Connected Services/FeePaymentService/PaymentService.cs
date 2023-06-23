﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FeePaymentService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Fault", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
    public partial class Fault : object
    {
        
        private string FaultMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FaultMessage
        {
            get
            {
                return this.FaultMessageField;
            }
            set
            {
                this.FaultMessageField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FeeItem", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
    public partial class FeeItem : object
    {
        
        private string FeeItemCodeField;
        
        private string FeeItemNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FeeItemCode
        {
            get
            {
                return this.FeeItemCodeField;
            }
            set
            {
                this.FeeItemCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FeeItemName
        {
            get
            {
                return this.FeeItemNameField;
            }
            set
            {
                this.FeeItemNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
    public partial class Student : object
    {
        
        private string AccountCurrencyField;
        
        private string AccountNameField;
        
        private string AccountNumberField;
        
        private string BillCurrencyField;
        
        private decimal BillValueField;
        
        private string CollectiveField;
        
        private string CollegeField;
        
        private string CurrentYearField;
        
        private string DepartmentField;
        
        private string FacultyField;
        
        private string FullnameField;
        
        private string GenderField;
        
        private int IsExactAmountRequiredField;
        
        private string ProgrammeStreamField;
        
        private string ResponseMessageField;
        
        private int ResponseValueField;
        
        private string StudentIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AccountCurrency
        {
            get
            {
                return this.AccountCurrencyField;
            }
            set
            {
                this.AccountCurrencyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AccountName
        {
            get
            {
                return this.AccountNameField;
            }
            set
            {
                this.AccountNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AccountNumber
        {
            get
            {
                return this.AccountNumberField;
            }
            set
            {
                this.AccountNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BillCurrency
        {
            get
            {
                return this.BillCurrencyField;
            }
            set
            {
                this.BillCurrencyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal BillValue
        {
            get
            {
                return this.BillValueField;
            }
            set
            {
                this.BillValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Collective
        {
            get
            {
                return this.CollectiveField;
            }
            set
            {
                this.CollectiveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string College
        {
            get
            {
                return this.CollegeField;
            }
            set
            {
                this.CollegeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CurrentYear
        {
            get
            {
                return this.CurrentYearField;
            }
            set
            {
                this.CurrentYearField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Department
        {
            get
            {
                return this.DepartmentField;
            }
            set
            {
                this.DepartmentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Faculty
        {
            get
            {
                return this.FacultyField;
            }
            set
            {
                this.FacultyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fullname
        {
            get
            {
                return this.FullnameField;
            }
            set
            {
                this.FullnameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender
        {
            get
            {
                return this.GenderField;
            }
            set
            {
                this.GenderField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IsExactAmountRequired
        {
            get
            {
                return this.IsExactAmountRequiredField;
            }
            set
            {
                this.IsExactAmountRequiredField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProgrammeStream
        {
            get
            {
                return this.ProgrammeStreamField;
            }
            set
            {
                this.ProgrammeStreamField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResponseMessage
        {
            get
            {
                return this.ResponseMessageField;
            }
            set
            {
                this.ResponseMessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ResponseValue
        {
            get
            {
                return this.ResponseValueField;
            }
            set
            {
                this.ResponseValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudentID
        {
            get
            {
                return this.StudentIDField;
            }
            set
            {
                this.StudentIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Response", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
    public partial class Response : object
    {
        
        private int ResponseIDField;
        
        private string ResponseMessageField;
        
        private string ResponseValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ResponseID
        {
            get
            {
                return this.ResponseIDField;
            }
            set
            {
                this.ResponseIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResponseMessage
        {
            get
            {
                return this.ResponseMessageField;
            }
            set
            {
                this.ResponseMessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResponseValue
        {
            get
            {
                return this.ResponseValueField;
            }
            set
            {
                this.ResponseValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Payment", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
    public partial class Payment : object
    {
        
        private decimal AmountField;
        
        private string BankNameField;
        
        private bool ConfirmedField;
        
        private string CurrencyIDField;
        
        private string NarrativeField;
        
        private string StudentIDField;
        
        private System.DateTime TimeSentField;
        
        private System.DateTime TransDateField;
        
        private string TransactionIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Amount
        {
            get
            {
                return this.AmountField;
            }
            set
            {
                this.AmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BankName
        {
            get
            {
                return this.BankNameField;
            }
            set
            {
                this.BankNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Confirmed
        {
            get
            {
                return this.ConfirmedField;
            }
            set
            {
                this.ConfirmedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CurrencyID
        {
            get
            {
                return this.CurrencyIDField;
            }
            set
            {
                this.CurrencyIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Narrative
        {
            get
            {
                return this.NarrativeField;
            }
            set
            {
                this.NarrativeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudentID
        {
            get
            {
                return this.StudentIDField;
            }
            set
            {
                this.StudentIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeSent
        {
            get
            {
                return this.TimeSentField;
            }
            set
            {
                this.TimeSentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TransDate
        {
            get
            {
                return this.TransDateField;
            }
            set
            {
                this.TransDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TransactionID
        {
            get
            {
                return this.TransactionIDField;
            }
            set
            {
                this.TransactionIDField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FeePaymentService.IPaymentService")]
    public interface IPaymentService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/CheckConnection", ReplyAction="http://tempuri.org/IPaymentService/CheckConnectionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(FeePaymentService.Fault), Action="http://tempuri.org/IPaymentService/CheckConnectionFaultFault", Name="Fault", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
        System.Threading.Tasks.Task<int> CheckConnectionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/ListFeeItems", ReplyAction="http://tempuri.org/IPaymentService/ListFeeItemsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(FeePaymentService.Fault), Action="http://tempuri.org/IPaymentService/ListFeeItemsFaultFault", Name="Fault", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
        System.Threading.Tasks.Task<FeePaymentService.FeeItem[]> ListFeeItemsAsync(string gid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/GetStudentData", ReplyAction="http://tempuri.org/IPaymentService/GetStudentDataResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(FeePaymentService.Fault), Action="http://tempuri.org/IPaymentService/GetStudentDataFaultFault", Name="Fault", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
        System.Threading.Tasks.Task<FeePaymentService.Student> GetStudentDataAsync(string gid, string feeItem, string studentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/SendPaymentNotification", ReplyAction="http://tempuri.org/IPaymentService/SendPaymentNotificationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(FeePaymentService.Fault), Action="http://tempuri.org/IPaymentService/SendPaymentNotificationFaultFault", Name="Fault", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
        System.Threading.Tasks.Task<FeePaymentService.Response> SendPaymentNotificationAsync(string gid, string feeItem, string studentID, string consumerName, string branchName, string transDate, string transactionID, string accountNumber, string narrative, string currencyID, decimal amount, string teller, string phoneNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/SendReversalNotification", ReplyAction="http://tempuri.org/IPaymentService/SendReversalNotificationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(FeePaymentService.Fault), Action="http://tempuri.org/IPaymentService/SendReversalNotificationFaultFault", Name="Fault", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
        System.Threading.Tasks.Task<FeePaymentService.Response> SendReversalNotificationAsync(string gid, string dateReversed, string reversedTransactionID, string reasonForReversal, string reversalTransactionID, string consumerName, string branchName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/SendTransactionConfirmation", ReplyAction="http://tempuri.org/IPaymentService/SendTransactionConfirmationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(FeePaymentService.Fault), Action="http://tempuri.org/IPaymentService/SendTransactionConfirmationFaultFault", Name="Fault", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
        System.Threading.Tasks.Task<FeePaymentService.Response> SendTransactionConfirmationAsync(string gid, string transactionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/ConfirmTransactionByAlternateID", ReplyAction="http://tempuri.org/IPaymentService/ConfirmTransactionByAlternateIDResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(FeePaymentService.Fault), Action="http://tempuri.org/IPaymentService/ConfirmTransactionByAlternateIDFaultFault", Name="Fault", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
        System.Threading.Tasks.Task<FeePaymentService.Response> ConfirmTransactionByAlternateIDAsync(string gid, string transactionID, string altTransactionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/ConfirmTransactionByPaymentService", ReplyAction="http://tempuri.org/IPaymentService/ConfirmTransactionByPaymentServiceResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(FeePaymentService.Fault), Action="http://tempuri.org/IPaymentService/ConfirmTransactionByPaymentServiceFaultFault", Name="Fault", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
        System.Threading.Tasks.Task<FeePaymentService.Response> ConfirmTransactionByPaymentServiceAsync(string gid, string transactionID, string altTransactionID, string paymentChannelID, string paymentService);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/GenerateOrderID", ReplyAction="http://tempuri.org/IPaymentService/GenerateOrderIDResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(FeePaymentService.Fault), Action="http://tempuri.org/IPaymentService/GenerateOrderIDFaultFault", Name="Fault", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
        System.Threading.Tasks.Task<string> GenerateOrderIDAsync(string gid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/GetTransactionDetail", ReplyAction="http://tempuri.org/IPaymentService/GetTransactionDetailResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(FeePaymentService.Fault), Action="http://tempuri.org/IPaymentService/GetTransactionDetailFaultFault", Name="Fault", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
        System.Threading.Tasks.Task<FeePaymentService.Payment> GetTransactionDetailAsync(string gid, string transactionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/GetResponseMessage", ReplyAction="http://tempuri.org/IPaymentService/GetResponseMessageResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(FeePaymentService.Fault), Action="http://tempuri.org/IPaymentService/GetResponseMessageFaultFault", Name="Fault", Namespace="http://schemas.datacontract.org/2004/07/PaymentServiceLibrary")]
        System.Threading.Tasks.Task<string> GetResponseMessageAsync(int responseID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IPaymentServiceChannel : FeePaymentService.IPaymentService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class PaymentServiceClient : System.ServiceModel.ClientBase<FeePaymentService.IPaymentService>, FeePaymentService.IPaymentService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PaymentServiceClient() : 
                base(PaymentServiceClient.GetDefaultBinding(), PaymentServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.SecureHttpBinding.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(PaymentServiceClient.GetBindingForEndpoint(endpointConfiguration), PaymentServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PaymentServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PaymentServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PaymentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<int> CheckConnectionAsync()
        {
            return base.Channel.CheckConnectionAsync();
        }
        
        public System.Threading.Tasks.Task<FeePaymentService.FeeItem[]> ListFeeItemsAsync(string gid)
        {
            return base.Channel.ListFeeItemsAsync(gid);
        }
        
        public System.Threading.Tasks.Task<FeePaymentService.Student> GetStudentDataAsync(string gid, string feeItem, string studentID)
        {
            return base.Channel.GetStudentDataAsync(gid, feeItem, studentID);
        }
        
        public System.Threading.Tasks.Task<FeePaymentService.Response> SendPaymentNotificationAsync(string gid, string feeItem, string studentID, string consumerName, string branchName, string transDate, string transactionID, string accountNumber, string narrative, string currencyID, decimal amount, string teller, string phoneNumber)
        {
            return base.Channel.SendPaymentNotificationAsync(gid, feeItem, studentID, consumerName, branchName, transDate, transactionID, accountNumber, narrative, currencyID, amount, teller, phoneNumber);
        }
        
        public System.Threading.Tasks.Task<FeePaymentService.Response> SendReversalNotificationAsync(string gid, string dateReversed, string reversedTransactionID, string reasonForReversal, string reversalTransactionID, string consumerName, string branchName)
        {
            return base.Channel.SendReversalNotificationAsync(gid, dateReversed, reversedTransactionID, reasonForReversal, reversalTransactionID, consumerName, branchName);
        }
        
        public System.Threading.Tasks.Task<FeePaymentService.Response> SendTransactionConfirmationAsync(string gid, string transactionID)
        {
            return base.Channel.SendTransactionConfirmationAsync(gid, transactionID);
        }
        
        public System.Threading.Tasks.Task<FeePaymentService.Response> ConfirmTransactionByAlternateIDAsync(string gid, string transactionID, string altTransactionID)
        {
            return base.Channel.ConfirmTransactionByAlternateIDAsync(gid, transactionID, altTransactionID);
        }
        
        public System.Threading.Tasks.Task<FeePaymentService.Response> ConfirmTransactionByPaymentServiceAsync(string gid, string transactionID, string altTransactionID, string paymentChannelID, string paymentService)
        {
            return base.Channel.ConfirmTransactionByPaymentServiceAsync(gid, transactionID, altTransactionID, paymentChannelID, paymentService);
        }
        
        public System.Threading.Tasks.Task<string> GenerateOrderIDAsync(string gid)
        {
            return base.Channel.GenerateOrderIDAsync(gid);
        }
        
        public System.Threading.Tasks.Task<FeePaymentService.Payment> GetTransactionDetailAsync(string gid, string transactionID)
        {
            return base.Channel.GetTransactionDetailAsync(gid, transactionID);
        }
        
        public System.Threading.Tasks.Task<string> GetResponseMessageAsync(int responseID)
        {
            return base.Channel.GetResponseMessageAsync(responseID);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SecureHttpBinding))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                result.Security.Transport.ClientCredentialType = System.ServiceModel.HttpClientCredentialType.Basic;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SecureHttpBinding))
            {
                return new System.ServiceModel.EndpointAddress("https://apps.knust.edu.gh/feepaymentservice/PaymentService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PaymentServiceClient.GetBindingForEndpoint(EndpointConfiguration.SecureHttpBinding);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PaymentServiceClient.GetEndpointAddress(EndpointConfiguration.SecureHttpBinding);
        }
        
        public enum EndpointConfiguration
        {
            
            SecureHttpBinding,
        }
    }
}

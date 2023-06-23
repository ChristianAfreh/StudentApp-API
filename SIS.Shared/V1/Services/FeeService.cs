using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FeePaymentService;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using SIS.Shared.DTOs;
using SIS.Shared.Exceptions;
using SIS.Shared.Helpers;
using SIS.Shared.V1.Repositories;

namespace SIS.Shared.V1.Services
{
    public interface IFeeService
    {
        Task<FeeSummaryGetDTO> GetFeeSummaryAsync(string studentId, int programmeStreamId);
        Task<FeeScheduleGetDTO> GetStudentFeeScheduleAsync(string studentId, int programmeStreamId, int acadYear);
        Task<List<FeeTransactionGetDTO>> GetStudentFeeTransactionAsync(string studentId, int programmeStreamId);
        Task<List<WSFeeItemGetDTO>> GetWSFeeItems();
        Task<Student> GetStudentData(string studentId, string feeItem);
        Task<PaymentNotificationGetDTO> SendPaymentNotification(PaymentAddDTO paymentRequest);
        Task<StudentPaymentResultDTO> GetAllPaymentsByStudentAsync(string studentId, int limit, int page, CancellationToken cancellationToken);
        Task<PaymentConfirmationDTO> ConfirmPayment(ManillaPaymentConfirmationDTO paymentConfirmation);
        public Task<List<FeeTransactionGetDTO>> GetStudentOtherFeeTransactionAsync(string studentId, int programmeStreamId);


	}

	public class FeeService : IFeeService
    {
        private readonly IStudentBillRepository _studentBillRepository;
        private readonly IUserPaymentRepository _userPaymentRepository;
        private readonly IBankRepository _bankRepository;
        private readonly IStudentFeeTransactionRepository _studentFeeTransactionRepository; 
        private readonly PaymentSettings _paymentSettings;
        private readonly PaymentServiceClient _paymentServiceClient;
        private readonly FunctionsService _functionsService;
        private readonly IMapper _mapper;
        private readonly string bankGId;
        private readonly IStudentRepository _studentRepository;

        public FeeService(IStudentBillRepository studentBillRepository, IStudentFeeTransactionRepository studentFeeTransactionRepository, IBankRepository bankRepository, IOptionsMonitor<PaymentSettings> optionsMonitor, IMapper mapper, PaymentServiceClient paymentServiceClient, FunctionsService functionsService, IStudentRepository studentRepository, IUserPaymentRepository userPaymentRepository)
        {
            _studentBillRepository = studentBillRepository;
            _studentFeeTransactionRepository = studentFeeTransactionRepository;
            _bankRepository = bankRepository;
            _paymentSettings = optionsMonitor.CurrentValue;
            bankGId = _paymentSettings.WSBankGId;
            _mapper = mapper;
            _paymentServiceClient = paymentServiceClient;

            _paymentServiceClient.ClientCredentials.UserName.UserName = _paymentSettings.WSUsername;
            _paymentServiceClient.ClientCredentials.UserName.Password = _paymentSettings.WSPassword;
            _functionsService = functionsService;
            _studentRepository = studentRepository;
            _userPaymentRepository = userPaymentRepository;
        }

        public async Task<FeeSummaryGetDTO> GetFeeSummaryAsync(string studentId, int programmeStreamId)
        {
            var result = await _studentBillRepository.GetFeeSummaryAsync(studentId, programmeStreamId);
            return result;
        }

        public async Task<Student> GetStudentData(string studentId, string feeItem)
        {
            var result = await _paymentServiceClient.GetStudentDataAsync(bankGId, feeItem, studentId);
            if(result.ResponseValue != 10)
            {
                throw new CustomException(result.ResponseMessage);
            }

            return result;
        }

        public async Task<FeeScheduleGetDTO> GetStudentFeeScheduleAsync(string studentId, int programmeStreamId, int acadYear)
        {
            var feeSummary = await GetFeeSummaryAsync(studentId, programmeStreamId);
            var feeScheduleItemEntities = await _studentBillRepository.GetStudentFeeScheduleItemsAsync(studentId, programmeStreamId, acadYear);

            if (feeScheduleItemEntities.Count == 0)
            {
                string message = "No fee schedule has been defined for " + GlobalFunction.GetAcadYearString(acadYear) + " academic year.";
                throw new CustomException(message);
            }

            var feeScheduleItemDTOs = feeScheduleItemEntities.Select(a => new FeeItemGetDTO
            {
                ItemName = a.FEETYPE,
                ItemAmount = a.AMOUNT
            }).ToList();

            var feeHeader = feeScheduleItemEntities.FirstOrDefault();
            var totalAmount = feeScheduleItemDTOs.Sum(x => x.ItemAmount);
            var amountPayable = totalAmount + -1 * (feeSummary.BalanceBF) + -1 * (feeSummary.SemesterPayment);


            var bankDTOs = (await _bankRepository.GetStudentBanksAsync(studentId, programmeStreamId)).Select(a => new BankGetDTO
            {
                BankName = a.BANKNAME,
                //BankLogo = a.LOGO,
                //BankLogoUrl = GetBankLogoUrl(a.BANKNAME, a.LOGO)
            }).ToList();

            var feeSchedule = new FeeScheduleGetDTO
            {
                TotalBill = feeSummary.TotalBill,
                TotalPayment = feeSummary.TotalPayment,
                TotalRefund = feeSummary.TotalRefund,
                TotalExemption = feeSummary.TotalExemption,
                TotalBalance = feeSummary.TotalBalance,
                TotalAmount = totalAmount,
                CurrencyId = feeSummary.CurrencyId,
                CurrencySymbol = feeSummary.CurrencySymbol,
                AcadYearString = feeHeader.ACADYEARSTRING,
                AmountPaid = feeSummary.SemesterPayment,
                BalanceBF = feeSummary.BalanceBF,
                AmountPayable = amountPayable,
                StudentId = feeHeader.STUDENTID,
                StudentName = feeHeader.STUDENTNAME,
                ProgrammeStream = feeHeader.PROGRAMMESTREAM,
                AcadLevelId = feeHeader.ACADLEVELID,
                AcadYear = feeHeader.ACADYEAR,
                FeeCategory = feeHeader.FEECATEGORY,
                Sem = feeHeader.SEM,
                IndexNo = feeHeader.INDEXNO,
                FeeItems = feeScheduleItemDTOs,
                Banks = bankDTOs,
            };

            return feeSchedule;
        }

        public async Task<List<FeeTransactionGetDTO>> GetStudentFeeTransactionAsync(string studentId, int programmeStreamId)
        {
            var entities = await _studentFeeTransactionRepository.GetStudentFeeTransctionsAsync(studentId, programmeStreamId);
            var dtos = _mapper.Map<List<FeeTransactionGetDTO>>(entities);
            return dtos;
        }   
        
        public async Task<List<FeeTransactionGetDTO>> GetStudentOtherFeeTransactionAsync(string studentId, int programmeStreamId)
        {
            var entities = await _studentFeeTransactionRepository.GetStudentFeePaymentAsync(studentId, programmeStreamId);
            var dtos = _mapper.Map<List<FeeTransactionGetDTO>>(entities);
            return dtos;
        }

        public async Task<List<WSFeeItemGetDTO>> GetWSFeeItems()
        {
            FeeItem[] feeList = await _paymentServiceClient.ListFeeItemsAsync(bankGId);
            var dtos = _mapper.Map <List<WSFeeItemGetDTO>> (feeList);
            return dtos;
        }

        private async Task<string> generateOrderId()
        {
            string orderId = await _paymentServiceClient.GenerateOrderIDAsync(bankGId);
            return orderId;
        }

        public async Task<PaymentNotificationGetDTO> SendPaymentNotification(PaymentAddDTO paymentRequest)
        {
            if ((await _paymentServiceClient.CheckConnectionAsync()) != 1)
            {
                throw new CustomException("Connection to payment service failed.");
            }

            string orderId = await generateOrderId();
            string feeItem = paymentRequest.FeeItem;
            var studentId = paymentRequest.StudentId;
            var currencyId = paymentRequest.CurrencyId;
            var amount = paymentRequest.Amount;
            string dateString = _functionsService.GetServerDate().ToString("yyyy-MM-dd HH:mm:ss");
            var studentData = await _studentRepository.GetStudentDetailsAsync(studentId);
            if (studentData == null)
            {
                throw new CustomException($"Student with ID {studentId} was not found.");
            }
            string studentPhoneNumber = _functionsService.GetStudentMobile(studentId);


            Student student = await GetStudentData(studentId, feeItem);
            if (student.ResponseValue == 10)
            {
                if (student.BillCurrency != currencyId)
                {
                    throw new CustomException("Currency mismatch");
                }

                var response = await _paymentServiceClient.SendPaymentNotificationAsync
                (
                    bankGId,
                    feeItem,
                    studentId,
                    "Student",
                    "Online",
                    dateString,
                    orderId,
                    student.AccountNumber,
                    $"{feeItem} for {studentId}",
                    currencyId,
                    amount,
                    null,
                    studentPhoneNumber
                );

                if (response.ResponseID == 1)
                {

                    //var notificationResponse = new PaymentNotificationResponse();
                    //notificationResponse.StudentId = studentId;
                    //notificationResponse.FeeItem = feeItem;
                    //notificationResponse.Amount = amount;
                    //notificationResponse.CurrencyId = currencyId;
                    //notificationResponse.OrderId = orderId;


                    var return_url = _paymentSettings.PaymentReturnUrl;

                    var checkOutBaseUrl = _paymentSettings.ManillaCheckOutUrl;

                    var nsanoPaymentRequest = new ManillaPaymentAddDTO
                    {
                        OrderId = orderId,
                        Amount = amount,
                        Currency = currencyId,
                        CustFirstname = studentData.OTHERNAME,
                        CustLastname = studentData.SURNAME,
                        CustEmail = studentData.EMAIL,
                        //CustPhone = studentPhoneNumber,
                        Description = $"Payment for {student.Fullname} ({studentId}).",
                        Services = new ManillaPaymentServiceDTO
                        {
                            Bank = paymentRequest.ShowBank,
                            Cards = paymentRequest.ShowCard,
                            MobileMoney = paymentRequest.ShowMobileMoney
                        },
                        ReturnUrl = return_url,
                        CancelUrl = return_url
                    };

                    string merchantId = _paymentSettings.ManillaMerchantId;

                    RestClient restClient = new RestClient(checkOutBaseUrl);
                    RestRequest request = new RestRequest();
                    request.Method = Method.Post;
                    request.AddHeader("Authorization", $"Bearer {merchantId}");
                    request.AddJsonBody(nsanoPaymentRequest);
                    var result = await restClient.ExecuteAsync<ManillaPaymentGetDTO>(request);

                    if (result.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        throw new CustomException("An error occurred whilst initiating payment. Please try again.");
                    }

                    if (result.Data.Code != "00")
                    {
                        throw new CustomException("An error occurred whilst initiating payment. Please try again.");
                    }


                    return new PaymentNotificationGetDTO { CheckOutUrl = result.Data.Data.Links.CheckoutUrl.ToString() };
                }
                else
                {
                    throw new CustomException(response.ResponseMessage);
                }
            }
            else
            {
                throw new CustomException(student.ResponseMessage);
            }
        }

        public async Task<PaymentConfirmationDTO> ConfirmPayment(ManillaPaymentConfirmationDTO manillaConfirmation)
        {

            int status = manillaConfirmation.status;
            string transactionId = manillaConfirmation.order_id;
            string altTransactionId = manillaConfirmation.transaction_id;
            var paymentConfirmationDTO = new PaymentConfirmationDTO() { StatusId = status };
            try
            {

                if (status == 1)
                {
                    string paymentLogoFolder = "~/Content/files/PaymentServiceLogo/";

                        HttpClient client = new HttpClient();
                        client.BaseAddress = new Uri("https://manilla.nsano.com");

                        string ApiKey = _paymentSettings.ManillaApiKey;
                        string MerchantId = _paymentSettings.ManillaMerchantId;

                        var transDetail = await _paymentServiceClient.GetTransactionDetailAsync(bankGId, transactionId);

                        dynamic req = new JObject();
                        req.order_id = transDetail.TransactionID;
                        req.merchant_apiKey = ApiKey;
                        req.merchant_id = MerchantId;


                        var payload = new StringContent(req.ToString(), Encoding.UTF8, "application/json");

                       

                        var response = client.PostAsync("/checkout/verify/", payload).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = response.Content.ReadAsStringAsync().Result;
                        try
                        {

                            var content = JsonConvert.DeserializeObject<ManillaResponse>(responseBody);

                            paymentConfirmationDTO.VerificationCode = content.code;
                            if (content.code == "00" && content?.data.status == "1")
                            {

                                //var wsPaymentDetail = paymentServiceClient.GetTransactionDetail(Gid, transactionId);
                                if (transDetail == null)
                                {
                                    throw new Exception($"Transaction with ID {transactionId} was not found in WS Payments.");
                                }

                                if ((double)transDetail.Amount > content.data.amount)
                                {
                                    //dbStud.MISMATCHPAYMENTS.Add(new MISMATCHPAYMENTS
                                    //{
                                    //    STUDENTID = transDetail.StudentID,
                                    //    TRANSACTIONID = transDetail.TransactionID,
                                    //    AMOUNTINSIS = transDetail.Amount,
                                    //    AMOUNTFROMNSANO = (decimal)content.data.amount,
                                    //    ALTRANSACTIONID = content.data.transactionId
                                    //});
                                    //dbStud.SaveChanges();

                                    throw new Exception("Amount mismatch. Please check MISMATCHPAYMENTS table.");
                                }


                                List<ManillaServiceType> serviceType = new List<ManillaServiceType>()
                                    {
                                        new ManillaServiceType() {code = "VISA", Name = "Visa", IconName = "ic_po_visacard.png"},
                                        new ManillaServiceType() {code = "MASTERCARD", Name = "Mastercard", IconName = "ic_po_mastercard.png"},
                                        new ManillaServiceType() {code = "MASTERCARDSC", Name = "Mastercard", IconName = "ic_po_mastercard.png"},
                                        new ManillaServiceType() {code = "AIRTEL", Name = "Airtel Money", IconName = "ic_po_airtelmoney.png"},
                                        new ManillaServiceType() {code = "MTN", Name = "MTN Mobile Money", IconName = "ic_po_mtnmobilemoney.png"},
                                        new ManillaServiceType() {code = "TIGO", Name = "Tigo Cash", IconName = "ic_po_tigocash.png"},
                                        new ManillaServiceType() {code = "VODAFONE", Name = "Vodafone Cash", IconName = "ic_po_vodafonecash.jpg"}
                                    };


                                var res = await _paymentServiceClient.ConfirmTransactionByPaymentServiceAsync(bankGId, transactionId, altTransactionId, content.data.channel, content.data.service);
                                if (res.ResponseID == 16 || res.ResponseID == 17)
                                {
                                    var payService = serviceType.Where(x => x.code == content.data.service).FirstOrDefault();

                                    string paymentServiceLogoUrl = "";
                                    string fileName = paymentLogoFolder + payService.IconName;
                                    //string mapPath = HttpContext.Current.Server.MapPath(fileName);
                                    //if (File.Exists(mapPath))
                                    //{
                                    //    paymentServiceLogoUrl = Url.Content(fileName);
                                    //}


                                    paymentConfirmationDTO.CurrencyId = transDetail.CurrencyID;
                                    paymentConfirmationDTO.Amount = transDetail.Amount.ToString();
                                    paymentConfirmationDTO.TransactionDate = transDetail.TransDate;
                                    paymentConfirmationDTO.TransactionId = transactionId;
                                    paymentConfirmationDTO.FeeItemCode = $"{transDetail.Narrative.Split()[0]}";
                                    paymentConfirmationDTO.PaymentService = payService.Name;
                                    paymentConfirmationDTO.Channel = content.data.channel;
                                    paymentConfirmationDTO.PaymentServiceLogoUrl = paymentServiceLogoUrl;

                                }
                                else
                                {
                                    paymentConfirmationDTO.StatusId = 0;
                                    paymentConfirmationDTO.VerificationMessage = res.ResponseMessage;
                                }
                            }
                            else
                            {
                                paymentConfirmationDTO.StatusId = 0;
                                paymentConfirmationDTO.VerificationMessage = content.msg;
                            }
                        }
                        catch (Exception)
                        {
                            var content = JsonConvert.DeserializeObject<ManillaErrorResponse>(responseBody);

                            paymentConfirmationDTO.StatusId = 0;
                            paymentConfirmationDTO.VerificationMessage = content.msg;
                            throw;
                        }

                    }
                  

                    if (paymentConfirmationDTO.StatusId == 0)
                    {
                        paymentConfirmationDTO.StatusMessage = "An error occurred.";
                    }
                    else
                    {
                        var feeItems = await GetWSFeeItems();
                        var feeItem = feeItems.FirstOrDefault(x => x.FeeItemCode == paymentConfirmationDTO.FeeItemCode);
                        string feeItemName;
                        if(feeItem != null)
                        {
                            feeItemName = feeItem.FeeItemName;
                        }
                        else
                        {
                            feeItemName = paymentConfirmationDTO.FeeItemCode;
                        }
                        paymentConfirmationDTO.FeeItemName = feeItemName;
                        paymentConfirmationDTO.StatusMessage = $"Your {feeItemName} payment has been received.";
                    }
                }
                else if (status == 2)
                {
                    paymentConfirmationDTO.StatusMessage = "Transaction was cancelled.";
                }
                else if (status == 3)
                {
                    paymentConfirmationDTO.StatusMessage = "Failure.";
                }
                else if (status == 4)
                {
                    paymentConfirmationDTO.StatusMessage = "System error.";
                }
                else
                {
                    paymentConfirmationDTO.StatusMessage = "Unknown response.";
                }
            }
            catch (Exception)
            {
                paymentConfirmationDTO.StatusId = 1000;
                paymentConfirmationDTO.StatusMessage = "An error occurred.";
                throw;
            }

            paymentConfirmationDTO.IsSuccess = paymentConfirmationDTO.StatusId == 1;
            return paymentConfirmationDTO;
        }

        public async Task<StudentPaymentResultDTO> GetAllPaymentsByStudentAsync(string studentId, int limit, int page, CancellationToken cancellationToken)
        {
            var entities = await _userPaymentRepository.GetAllPaymentsByStudentAsync(studentId, limit, page, cancellationToken);
            var dtos = _mapper.Map<List<UserPaymentGetDTO>>(entities.Items);
            //return dtos;

            return new StudentPaymentResultDTO
            {
                CurrentPage = entities.CurrentPage,
                TotalPages = entities.TotalPages,
                TotalItems = entities.TotalItems,
                Items = dtos
            };
        }
    }
}

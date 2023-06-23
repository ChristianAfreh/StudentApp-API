using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeePaymentService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIS.Shared.DTOs;
using SIS.Shared.V1.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SIS.API.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class PaymentController : ControllerBase
    {
        private readonly IFeeService _feeService;

        public PaymentController(IFeeService feeService)
        {
            _feeService = feeService;
        }

        [HttpGet("WSFeeItems")]
        public async Task<ActionResult<List<WSFeeItemGetDTO>>> GetWSFeeItems()
        {
            return Ok(await _feeService.GetWSFeeItems());
        }

        [HttpGet("StudentData")]
        public async Task<ActionResult<Student>> GetStudentData(string studentId, string feeItem)
        {
            return Ok(await _feeService.GetStudentData(studentId, feeItem));
        }

        [HttpGet("Confirmation")]
        [AllowAnonymous]
        public async Task<ActionResult<PaymentConfirmationDTO>> ConfirmPayment(int status, string transaction_id, string order_id)
        {
            ManillaPaymentConfirmationDTO paymentConfirmation = new ManillaPaymentConfirmationDTO
            {
                transaction_id = transaction_id,
                order_id = order_id,
                status = status
            };
            return Ok(await _feeService.ConfirmPayment(paymentConfirmation));
        }


        [HttpPost("Confirmation")]
        [AllowAnonymous]
        public async Task<ActionResult<PaymentConfirmationDTO>> ConfirmPayment([FromForm] ManillaPaymentConfirmationDTO paymentConfirmation)
        {
            return Ok(await _feeService.ConfirmPayment(paymentConfirmation));
        }


        [HttpPost("Notification")]
        public async Task<ActionResult<PaymentNotificationGetDTO>> SendPaymentNotification(PaymentAddDTO paymentRequest)
        {
            return Ok(await _feeService.SendPaymentNotification(paymentRequest));
        }
    }
}

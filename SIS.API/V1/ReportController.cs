using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIS.Shared.V1.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SIS.API.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [Authorize]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;
        private readonly IEmailService _emailService;

        public ReportController(IReportService reportService, IEmailService emailService)
        {
            _reportService = reportService;
            _emailService = emailService;
        }

        [HttpGet("{studentId}/ResultSlip")]
        public async Task<ActionResult> GetStudentResultSlip(string studentId, int acadYear, int sem)
        {
            var data = await _reportService.GetStudentResultSlip(studentId, acadYear, sem);
            return new FileContentResult(data, MediaTypeNames.Application.Pdf)
            {
                FileDownloadName = $"Results Slip {studentId} {acadYear} {sem}.pdf"
            };
        }

        [HttpGet("{studentId}/RegistrationSlip")]
        public async Task<ActionResult> GetStudentRegistrationSlip(string studentId, int acadYear, int sem, bool email = false)
        {
            var data = await _reportService.GetStudentRegistrationSlip(studentId, acadYear, sem);
            if (email)
            {
                await _emailService.SendRegistrationReportAsync(studentId, acadYear, sem, data);
                return Ok();
            }
            else
            {
                return new FileContentResult(data, MediaTypeNames.Application.Pdf)
                {
                    FileDownloadName = $"Registration Slip {studentId} {acadYear} {sem}.pdf"
                };
            }
        }

        [HttpGet("{studentId}/Bill")]
        public async Task<ActionResult> GetStudentBill(string studentId, int acadYear)
        {
            var data = await _reportService.GetStudentBill(studentId, acadYear);
            return new FileContentResult(data, MediaTypeNames.Application.Pdf)
            {
                FileDownloadName = $"Bill {studentId} {acadYear}.pdf"
            };
        }

        [HttpGet("{studentId}/TransactionReceipt")]
        public async Task<ActionResult> GetStudentTransactionReceipt(string studentId, string ofId)
        {
            var data = await _reportService.GetStudentTransactionReceipt(studentId, ofId);
            return new FileContentResult(data, MediaTypeNames.Application.Pdf)
            {
                FileDownloadName = $"Receipt {studentId} {ofId}.pdf"
            };
        }
    }
}

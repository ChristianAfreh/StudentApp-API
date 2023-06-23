using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIS.Shared.DTOs;
using SIS.Shared.V1.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SIS.API.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class FeeController : ControllerBase
    {
        private readonly IFeeService _feeService;

        public FeeController(IFeeService feeService)
        {
            _feeService = feeService;
        }

        //[HttpGet("{studentId}/Bill")]
        //public Task<ActionResult<FeeSummaryGetDTO>> GetStudentBill(string studentId, int acadYear, int sem)
        //{
        //    return _feeService.GetStudentDetails(studentId);
        //}

        //[HttpGet("{studentId}/Summary")]
        //public ActionResult<FeeSummaryGetDTO> GetStudentFeeSummary(string studentId)
        //{
        //    return _feeService.GetFeeSummary(studentId);
        //}

        //[HttpGet("{studentId}/FeeSchedule")]
        //public ActionResult<FeeSummaryGetDTO> GetStudentFeeSchedule(string studentId)
        //{
        //    return _feeService.GetFeeSummary(studentId);
        //}
    }
}

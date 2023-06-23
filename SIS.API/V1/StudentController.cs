using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
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
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IFeeService _feeService;
        private readonly ITimetableService _timetableService;

        public StudentController(IStudentService studentService, IFeeService feeService, ITimetableService timetableService)
        {
            _studentService = studentService;
            _feeService = feeService;
            _timetableService = timetableService;
        }

        [HttpGet("{studentId}")]
        public async Task<ActionResult<StudentGetDTO>> GetStudentAsync(string studentId)
        {
            return Ok(await _studentService.GetStudentDetailsAsync(studentId));
        }

        [HttpPut]
        public async Task<ActionResult> UpdateStudentAsync(StudentUpdateDTO student)
        {
            await _studentService.UpdateStudentDetailsAsync(student);
            return Ok();
        }

        [HttpGet("{studentId}/Semester")]
        public async Task<ActionResult<List<StudentSemesterGetDTO>>> GetStudentSemestersAsync(string studentId)
        {
            return Ok(await _studentService.GetStudentSemestersAsync(studentId));
        }

        [HttpGet("{studentId}/Photo")]
        public async Task<ActionResult> GetPhoto(string studentId)
        {
            var data = await _studentService.GetPhoto(studentId);
            return File(data, MediaTypeNames.Image.Jpeg);
        }

        [HttpGet("{studentId}/FeeSchedule")]
        public async Task<ActionResult<FeeScheduleGetDTO>> GetStudentFeeScheduleAsync(string studentId, int programmeStreamId, int acadYear)
        {
            var schedule = await _feeService.GetStudentFeeScheduleAsync(studentId, programmeStreamId, acadYear);
            return Ok(schedule);
        }

        [HttpGet("{studentId}/FeeTransaction")]
        public async Task<ActionResult<List<FeeTransactionGetDTO>>> GetStudentFeeTransactionAsync(string studentId, int programmeStreamId)
        {
            var schedule = await _feeService.GetStudentFeeTransactionAsync(studentId, programmeStreamId);
            return Ok(schedule);
        }

        [HttpGet("{studentId}/Payment")]
        public async Task<ActionResult<List<UserPaymentGetDTO>>> GetStudentPaymentsAsync(string studentId, CancellationToken cancellationToken, int limit = 50, int page = 1)
        {
            var result = await _feeService.GetAllPaymentsByStudentAsync(studentId, limit, page, cancellationToken);
            return Ok(result);
        }

        [HttpGet("{studentId}/ProgrammeOption")]
        public async Task<ActionResult<List<ProgrammeOptionGetDTO>>> GetStudentProgrammeOptionsAsync(string studentId)
        {
            var data = await _studentService.GetStudentProgrammeOptionsAvailableOnlineAsync(studentId);
            return Ok(data);
        }

        [HttpPut("{studentId}/ProgrammeOption")]
        public async Task<ActionResult> UpdateStudentProgrammeOptionsAsync(string studentId, StudentProgrammeOptionUpdateDTO studentProgrammeOption)
        {
            await _studentService.UpdateStudentProgrammeOption(studentId, studentProgrammeOption);
            return Ok();
        }

        [HttpGet("{studentId}/CourseSchedule")]
        [AllowAnonymous]
        public async Task<ActionResult<List<CourseScheduleGetDTO>>> GetStudentCourseScheduleAsync(string studentId, int acadYear, int semesterId)
        {
            var accessToken = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "").Trim();
            var data = await _timetableService.GetStudentCourseScheduleAsync(studentId, acadYear, semesterId, accessToken);
            return Ok(data);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIS.Shared.DTOs;
using SIS.Shared.Helpers;
using SIS.Shared.V1.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SIS.API.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class AcademicRecordController : ControllerBase
    {
        private readonly IAcademicRecordService _academicRecordService;

        public AcademicRecordController(IAcademicRecordService academicRecordService)
        {
            _academicRecordService = academicRecordService;
        }

        [HttpGet("{studentId}")]
        public async Task<ActionResult> GetAsync(string studentId, int acadYear, int sem)
        {
            var result = await _academicRecordService.GetSemesterResultsAsync(studentId, acadYear, sem);
            return Ok(result);
        }

        [HttpGet("RegistrationParameters/{studentId}")]
        public async Task<ActionResult<RegistrationParametersGetDTO>> GetRegistrationParametersAsync(string studentId, string app = "AIM", int appVersion = -1)
        {
            var username = GlobalFunction.GetUsername(User);
            var parameters = await _academicRecordService.GetRegistrationParametersAsync(studentId, username, app, appVersion);
            return Ok(parameters);

        }

        [HttpGet("RegistrationCourses/{studentId}")]
        public async Task<ActionResult<List<RegistrationCourseGetDTO>>> GetRegistrationCoursesAsync(string studentId, string app = "AIM", int appVersion = -1)
        {
            var results = await _academicRecordService.GetRegistrationCoursesAsync(studentId);
            return Ok(results);

        }

        [HttpPost("RegistrationCourses/{studentId}/Online")]
        public async Task<ActionResult<List<RegisteredCourseGetDTO>>> SaveRegistrationCoursesOnlineAsync(List<RegistrationCourseAddDTO> courses, string studentId, string app = "AIM", int appVersion = -1)
        {
            string username = GlobalFunction.GetUsername(User);
            var registeredCourses = await _academicRecordService.SaveRegistrationCoursesOnlineAsync(studentId, username, app, appVersion, courses);
            return Ok(registeredCourses);
        }

        [HttpPost("RegistrationCourses/Sync")]
        public async Task<ActionResult> SyncAcademicRecordsAsync(string studentId, string app = "AIM", int appVersion = -1)
        {
            string username = GlobalFunction.GetUsername(User);
            await _academicRecordService.SyncAcademicRecordsAsync(username, studentId, app, appVersion);
            return Ok();
        }
    }
}

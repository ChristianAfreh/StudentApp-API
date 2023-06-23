using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using SIS.Shared.DTOs;
using SIS.Shared.V1.Services;
using System.Threading.Tasks;

namespace SIS.API.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class CourseScheduleController : ControllerBase
    {
        private readonly ITimetableService _timetableService;

        public CourseScheduleController(ITimetableService timetableService)
        {
            _timetableService = timetableService;
        }

        [HttpGet("{courseScheduleId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CourseScheduleGetDetailDTO))]
        public async Task<ActionResult<CourseScheduleGetDetailDTO>> GetCourseSchedule(int courseScheduleId)
        {
            var accessToken = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "").Trim();

            var result = await _timetableService.GetCourseScheduleDetailAsync(courseScheduleId, accessToken);
            return Ok(result);
        }
    }
}

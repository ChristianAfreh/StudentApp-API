using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class LecturerAssessmentController : ControllerBase
    {
        private readonly ILecturerAssessmentService _lecturerAssessmentService;

        public LecturerAssessmentController(ILecturerAssessmentService lecturerAssessmentService)
        {
            _lecturerAssessmentService = lecturerAssessmentService;
        }

        [HttpGet("{studentId}/Lecturer")]
        public async Task<ActionResult<AssessmentLecturerGetDTO>> GetLecturersForAssessment(string studentId)
        {
            var result = await _lecturerAssessmentService.GetLecturersForRegisteredCoursesAsync(studentId);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<AssessmentGetDTO>> GetAssessment(string studentId, string courseCode)
        {
            var result = await _lecturerAssessmentService.GetAssessmentAsync(studentId, courseCode);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> SaveAssessmentAnswers(AssessmentAddDTO assessment)
        {
            await _lecturerAssessmentService.SaveAssessmentAsync(assessment);
            return Ok();
        }
    }
}

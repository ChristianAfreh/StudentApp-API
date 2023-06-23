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
    public class RegionController : ControllerBase
    {
        private readonly ISelectOptionService _selectOptionService;

        public RegionController(ISelectOptionService selectOptionService)
        {
            _selectOptionService = selectOptionService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SelectOptionGetDTO>>> GetRegions()
        {
            return Ok(await _selectOptionService.GetRegionsAsync());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SIS.Shared.DTOs;
using SIS.Shared.Settings;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SIS.API.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ApiController]
    //[Authorize]
    public class MiscController : Controller
    {
        private readonly MobileAppSettingDTO _mobileAppSetting;

        public MiscController(IOptions<MobileAppSettingDTO> mobileAppSetting)
        {
            _mobileAppSetting = mobileAppSetting.Value;
        }

        [HttpGet("MobileAppSettings")]
        public ActionResult<MobileAppSettingDTO> GetMobileAppSettings()
        {
            return Ok(_mobileAppSetting);
        }
    }
}


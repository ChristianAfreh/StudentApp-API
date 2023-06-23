using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIS.Shared.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SIS.API.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var username = User.FindFirstValue("account_id");
            var accountType = User.FindFirstValue("account_type");
            var ss = User.Identity.Name;
            return new string[] { "value1", "value2" };
        }

        //[HttpPost("Device")]
        //public async Task<ActionResult> RegisterDevice()
        //{
        //    var androidUpdateSettings = new UpdateSettingDTO
        //    {
        //        AppPlatform = "Android",
        //        AltDownloadUrl = "https://drive.google.com/file/d/0B2RAe_lWY2ZIZExWZm9vQ0hyUUU/view?usp=sharing&resourcekey=0--SjX1ew9z-p25Xan5jBajg",
        //        IsCritical = true,
        //        MinVersion = 33,
        //        StoreDownloadUrl = "https://play.google.com/store/apps/details?id=gh.edu.knust.aim"
        //    };


        //    var updateSettings = new List<UpdateSettingDTO> { androidUpdateSettings };
        //    var mobileAppSettings = new MobileAppSettingDTO
        //    {
        //        PasswordResetUrl = "",
        //        TimeTableApiBaseUrl = "",
        //        UpdateSettings = updateSettings,
        //        AboutApp = "Academic Information Manager (AIM) is the official mobile app for students of Kwame Nkrumah University of Science and Technology. It is a mobile companion of the online student portal which is also a part of KNUST Student Information System. It's main objective is to bring functions of the online student portal to mobile devices."
        //    };
        //    return Ok(mobileAppSettings);

        //}
    }
}

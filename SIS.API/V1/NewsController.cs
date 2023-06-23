using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class NewsController : ControllerBase
    {
        private readonly IRSSFeedService _rSSFeedService;

        public NewsController(IRSSFeedService rSSFeedService)
        {
            _rSSFeedService = rSSFeedService;
        }

        [HttpGet]
        public ActionResult<List<NewsFeedGetDTO>> Get()
        {
            var newsItems = _rSSFeedService.GetNewsList();
            return newsItems;
        }
    }
}

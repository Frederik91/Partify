using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Partify.Core.Helpers;

namespace Partify.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class YouTubeController : ControllerBase
    {
        private readonly ILogger<YouTubeController> _logger;
        private readonly IYouTubeServiceWrapper _youTubeServiceWrapper;

        public YouTubeController(ILogger<YouTubeController> logger, IYouTubeServiceWrapper youTubeServiceWrapper)
        {
            _logger = logger;
            _youTubeServiceWrapper = youTubeServiceWrapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetVideo(string artist, string album, string song)
        {
            try
            {
                var result = await _youTubeServiceWrapper.GetVideo(artist, album, song);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to get video", artist, album, song);
                return BadRequest();
            }
        }
    }
}

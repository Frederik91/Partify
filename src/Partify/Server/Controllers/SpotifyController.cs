using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Partify.Server.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class SpotifyController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SpotifyController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("AuthenticationUrl")]
        public string AuthenticationUrl([FromBody]string redirectBaseUri)
        {
            var url = HttpUtility.UrlEncode(redirectBaseUri);
            var clientId = _configuration["partify:spotifyClientId"];
            return
                $"https://accounts.spotify.com/authorize?client_id={clientId}&redirect_uri={url}callback&scope=streaming%20user-read-private%20user-read-email&response_type=token&state=123";
        }
    }
}

using System.Linq;
using System.Threading.Tasks;
using Google.Apis.YouTube.v3;
using Partify.Core.Models;

namespace Partify.Core.Helpers
{
    public class YouTubeServiceWrapper : IYouTubeServiceWrapper
    {
        private readonly YouTubeService _youTubeService;

        public YouTubeServiceWrapper(YouTubeService youTubeService)
        {
            _youTubeService = youTubeService;
        }

        public async Task<YouTubeSongResult> GetVideo(string artist, string album, string song)
        {
            var searchListRequest = _youTubeService.Search.List("snippet");
            searchListRequest.Q = $"{artist} {album} {song}";
            searchListRequest.MaxResults = 1;
            var result = await searchListRequest.ExecuteAsync();
            return new YouTubeSongResult { VideoId = result.Items.FirstOrDefault()?.Id.VideoId };
        }
    }
}

using System.Linq;
using System.Threading.Tasks;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Partify.Shared.Models;
using Partify.Shared.Models.Spotify;
using Partify.Shared.Services;
using VideoDto = Partify.Shared.Models.YouTube.VideoDto;

namespace Partify.Shared.Helpers
{
    public class YouTubeServiceWrapper : IYouTubeServiceWrapper
    {
        private readonly YouTubeService _youTubeService;
        private readonly IVideoService _videoService;
        private readonly ITrackService _trackService;

        public YouTubeServiceWrapper(YouTubeService youTubeService, IVideoService videoService, ITrackService trackService)
        {
            _youTubeService = youTubeService;
            _videoService = videoService;
            _trackService = trackService;
        }

        public async Task<VideoDto> GetVideo(string spotifyId, string artist, string album, string song)
        {
            var video = await _videoService.Get(spotifyId);
            if (video != null)
                return video;

            var track = await _trackService.Get(spotifyId) ?? await _trackService.Create(new CreateTrackRequest { SpotifyId = spotifyId, Album = album, Name = song, Artist = artist });

            var searchListRequest = _youTubeService.Search.List("snippet");
            searchListRequest.Q = $"{artist} {album} {song}";
            searchListRequest.MaxResults = 1;
            var result = await searchListRequest.ExecuteAsync();
            if (!(result.Items.FirstOrDefault() is { } searchResult))
                return null;

            return await _videoService.Create(new CreateVideoRequest { TrackId = track.Id, YouTubeId = searchResult.Id.VideoId });
        }
    }
}

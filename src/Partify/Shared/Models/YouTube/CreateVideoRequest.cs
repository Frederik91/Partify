using System;

namespace Partify.Shared.Models.Spotify
{
    public class CreateVideoRequest
    {
        public string YouTubeId { get; set; }
        public Guid TrackId { get; set; }
    }
}
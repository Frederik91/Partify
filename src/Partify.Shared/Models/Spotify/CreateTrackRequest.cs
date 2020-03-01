using System.Collections.Generic;

namespace Partify.Shared.Models.Spotify
{
    public class CreateTrackRequest
    {
        public string SpotifyId { get; set; }
        public string Name { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
    }
}
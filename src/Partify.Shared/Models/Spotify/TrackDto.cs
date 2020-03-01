using System;
using System.Collections.Generic;
using System.Text;

namespace Partify.Shared.Models.Spotify
{
    public class TrackDto
    {
        public Guid Id { get; set; }
        public string SpotifyId { get; set; }
        public string Name { get; set; }
        public int DurationMs { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
    }
}

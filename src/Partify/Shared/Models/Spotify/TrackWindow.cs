using System.Collections.Generic;

namespace Partify.Shared.Models.Spotify
{
    public class TrackWindow
    {
        public Track CurrentTrack { get; set; }
        public List<Track> NextTracks { get; set; }
        public List<Track> PreviousTracks { get; set; }
    }
}
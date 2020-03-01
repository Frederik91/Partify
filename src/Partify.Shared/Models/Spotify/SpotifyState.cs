namespace Partify.Shared.Models.Spotify
{
    public class SpotifyState
    {
        public Context Context { get; set; }
        public int Bitrate { get; set; }
        public double Position { get; set; }
        public int Duration { get; set; }
        public bool Paused { get; set; }
        public bool Shuffle { get; set; }
        public int RepeatMode { get; set; }
        public TrackWindow TrackWindow { get; set; }
        public long Timestamp { get; set; }
        public Restrictions Restrictions { get; set; }
        public Disallows Disallows { get; set; }
    }
}

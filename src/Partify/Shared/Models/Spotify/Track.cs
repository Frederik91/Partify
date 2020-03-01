using System.Collections.Generic;

namespace Partify.Shared.Models.Spotify
{
    public class Track
    {
        public string Id { get; set; }
        public string Uri { get; set; }
        public string Type { get; set; }
        public string LinkedFromUri { get; set; }
        public LinkedFrom LinkedFrom { get; set; }
        public string MediaType { get; set; }
        public string Name { get; set; }
        public int DurationMs { get; set; }
        public List<Artist> Artists { get; set; }
        public Album Album { get; set; }
        public bool IsPlayable { get; set; }
    }
}
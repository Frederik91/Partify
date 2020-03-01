using System.Collections.Generic;

namespace Partify.Shared.Models.Spotify
{
    public class Album
    {
        public string Uri { get; set; }
        public string Name { get; set; }
        public List<Image> Images { get; set; }
    }
}
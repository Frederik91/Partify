using System;
using System.Collections.Generic;
using System.Text;

namespace Partify.Shared.Models.YouTube
{
    public class VideoDto
    {
        public Guid Id { get; set; }
        public string YouTubeId { get; set; }
        public double Duration { get; set; }
    }
}

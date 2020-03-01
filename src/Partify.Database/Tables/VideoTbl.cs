using System;
using System.Collections.Generic;
using System.Text;

namespace Partify.Database.Tables
{
    public class VideoTbl
    {
        public Guid Id { get; set; }
        public string YouTubeId { get; set; }
        public Guid TrackId { get; set; }
        public TrackTbl Track { get; set; }
    }
}

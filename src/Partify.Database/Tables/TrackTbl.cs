using System;
using System.Collections.Generic;
using System.Text;

namespace Partify.Database.Tables
{
    public class TrackTbl
    {
        public Guid Id { get; set; }
        public string SpotifyId { get; set; }
        public string Artist { get; internal set; }
        public string Album { get; internal set; }
        public string Name { get; internal set; }
    }
}

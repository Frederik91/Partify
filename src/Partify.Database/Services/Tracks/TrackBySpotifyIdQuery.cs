using CQRS.Query.Abstractions;
using Partify.Database.Tables;
using Partify.Shared.Models.Spotify;

namespace Partify.Database.Services.Tracks
{
    public class TrackBySpotifyIdQuery : IQuery<TrackTbl>
    {
        public string SpotifyId { get; set; }
    }
}
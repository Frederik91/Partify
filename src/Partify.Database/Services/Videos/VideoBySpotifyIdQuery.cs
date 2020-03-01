using CQRS.Query.Abstractions;
using Partify.Database.Tables;
using Partify.Shared.Models.YouTube;

namespace Partify.Database.Services.Videos
{
    public class VideoBySpotifyIdQuery : IQuery<VideoTbl>
    {
        public string SpotifyId { get; set; }
    }
}
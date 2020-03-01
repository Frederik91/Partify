using System.Threading;
using System.Threading.Tasks;
using CQRS.Query.Abstractions;
using Microsoft.EntityFrameworkCore;
using Partify.Database.Services.Tracks;
using Partify.Database.Tables;

namespace Partify.Database.Services.Videos
{
    public class VideoBySpotifyIdQueryHandler : IQueryHandler<VideoBySpotifyIdQuery, VideoTbl>
    {
        private readonly PartifyContext _context;

        public VideoBySpotifyIdQueryHandler(PartifyContext context)
        {
            _context = context;
        }

        public Task<VideoTbl> HandleAsync(VideoBySpotifyIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _context.Videos.Include(x => x.Track).FirstOrDefaultAsync(x => x.Track.SpotifyId == query.SpotifyId, cancellationToken);
        }
    }
}

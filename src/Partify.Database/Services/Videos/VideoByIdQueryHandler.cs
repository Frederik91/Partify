using System.Threading;
using System.Threading.Tasks;
using CQRS.Query.Abstractions;
using Microsoft.EntityFrameworkCore;
using Partify.Database.Services.Tracks;
using Partify.Database.Tables;

namespace Partify.Database.Services.Videos
{
    public class VideoByIdQueryHandler : IQueryHandler<VideoByIdQuery, VideoTbl>
    {
        private readonly PartifyContext _context;

        public VideoByIdQueryHandler(PartifyContext context)
        {
            _context = context;
        }

        public Task<VideoTbl> HandleAsync(VideoByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _context.Videos.FirstOrDefaultAsync(x => x.Id == query.Id, cancellationToken);
        }
    }
}

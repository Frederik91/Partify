using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CQRS.Query.Abstractions;
using Microsoft.EntityFrameworkCore;
using Partify.Database.Tables;

namespace Partify.Database.Services.Tracks
{
    public class TrackBySpotifyIdQueryHandler : IQueryHandler<TrackBySpotifyIdQuery, TrackTbl>
    {
        private readonly PartifyContext _context;

        public TrackBySpotifyIdQueryHandler(PartifyContext context)
        {
            _context = context;
        }

        public Task<TrackTbl> HandleAsync(TrackBySpotifyIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _context.Tracks.FirstOrDefaultAsync(x => x.SpotifyId == query.SpotifyId, cancellationToken);
        }
    }
}

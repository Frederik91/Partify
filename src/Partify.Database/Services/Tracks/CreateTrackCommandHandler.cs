using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CQRS.Command.Abstractions;
using Partify.Database.Tables;

namespace Partify.Database.Services.Tracks
{
    public class CreateTrackCommandHandler : ICommandHandler<CreateTrackCommand>
    {
        private readonly PartifyContext _context;

        public CreateTrackCommandHandler(PartifyContext context)
        {
            _context = context;
        }

        public Task HandleAsync(CreateTrackCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var track = new TrackTbl { Id = command.Id, SpotifyId = command.Request.SpotifyId, Artist = command.Request.Artist, Album = command.Request.Album, Name = command.Request.Name };
            _context.Tracks.Add(track);
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}

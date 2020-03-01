using System.Threading;
using System.Threading.Tasks;
using CQRS.Command.Abstractions;
using Partify.Database.Tables;

namespace Partify.Database.Services.Videos
{
    public class CreateVideoCommandHandler : ICommandHandler<CreateVideoCommand>
    {
        private readonly PartifyContext _context;

        public CreateVideoCommandHandler(PartifyContext context)
        {
            _context = context;
        }

        public Task HandleAsync(CreateVideoCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var track = new VideoTbl { Id = command.Id, TrackId = command.Request.TrackId };
            _context.Videos.Add(track);
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}

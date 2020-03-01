using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CQRS.Command.Abstractions;
using CQRS.Query.Abstractions;
using Partify.Shared.Models.Spotify;
using Partify.Shared.Services;

namespace Partify.Database.Services.Tracks
{
    public class TrackService : ITrackService
    {
        private readonly ICommandExecutor _commandExecutor;
        private readonly IQueryExecutor _queryExecutor;
        private readonly IMapper _mapper;

        public TrackService(ICommandExecutor commandExecutor, IQueryExecutor queryExecutor, IMapper mapper)
        {
            _commandExecutor = commandExecutor;
            _queryExecutor = queryExecutor;
            _mapper = mapper;
        }

        public async Task<TrackDto> Get(Guid id)
        {
            var track = await _queryExecutor.ExecuteAsync(new TrackByIdQuery { Id = id });
            return track is null ? null : _mapper.Map<TrackDto>(track);
        }

        public async Task<TrackDto> Get(string spotifyId)
        {
            var track = await _queryExecutor.ExecuteAsync(new TrackBySpotifyIdQuery { SpotifyId = spotifyId });
            return track is null ? null : _mapper.Map<TrackDto>(track);
        }

        public async Task<TrackDto> Create(CreateTrackRequest request)
        {
            var command = new CreateTrackCommand { Id = Guid.NewGuid(), Request = request };
            await _commandExecutor.ExecuteAsync(command);
            return await Get(command.Id);
        }
    }
}

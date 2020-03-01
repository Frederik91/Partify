using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CQRS.Command.Abstractions;
using CQRS.Query.Abstractions;
using Partify.Database.Services.Tracks;
using Partify.Shared.Models.Spotify;
using Partify.Shared.Models.YouTube;
using Partify.Shared.Services;

namespace Partify.Database.Services.Videos
{
    public class VideoService : IVideoService
    {
        private readonly ICommandExecutor _commandExecutor;
        private readonly IQueryExecutor _queryExecutor;
        private readonly IMapper _mapper;

        public VideoService(ICommandExecutor commandExecutor, IQueryExecutor queryExecutor, IMapper mapper)
        {
            _commandExecutor = commandExecutor;
            _queryExecutor = queryExecutor;
            _mapper = mapper;
        }

        public async Task<VideoDto> Get(Guid id)
        {
            var video = await _queryExecutor.ExecuteAsync(new VideoByIdQuery { Id = id });
            return video is null ? null : _mapper.Map<VideoDto>(video);
        }

        public async Task<VideoDto> Get(string spotifyId)
        {
            var video = await _queryExecutor.ExecuteAsync(new VideoBySpotifyIdQuery { SpotifyId = spotifyId });
            return video is null ? null : _mapper.Map<VideoDto>(video);
        }

        public async Task<VideoDto> Create(CreateVideoRequest request)
        {
            var command = new CreateVideoCommand { Id = Guid.NewGuid(), Request = request };
            await _commandExecutor.ExecuteAsync(command);
            return await Get(command.Id);
        }
    }
}

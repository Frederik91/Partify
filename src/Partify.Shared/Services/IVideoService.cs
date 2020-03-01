using System;
using System.Threading.Tasks;
using Partify.Shared.Models.Spotify;
using Partify.Shared.Models.YouTube;

namespace Partify.Shared.Services
{
    public interface IVideoService
    {
        Task<VideoDto> Get(Guid id);
        Task<VideoDto> Get(string spotifyId);
        Task<VideoDto> Create(CreateVideoRequest request);
    }
}
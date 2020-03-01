using System;
using System.Threading.Tasks;
using Partify.Shared.Models.Spotify;

namespace Partify.Shared.Services
{
    public interface ITrackService
    {
        Task<TrackDto> Get(Guid id);
        Task<TrackDto> Get(string spotifyId);
        Task<TrackDto> Create(CreateTrackRequest request);
    }
}
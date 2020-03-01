using System.Threading.Tasks;
using Partify.Shared.Models;
using Partify.Shared.Models.YouTube;

namespace Partify.Shared.Helpers
{
    public interface IYouTubeServiceWrapper
    {
        Task<VideoDto> GetVideo(string spotifyId, string artist, string album, string song);
    }
}
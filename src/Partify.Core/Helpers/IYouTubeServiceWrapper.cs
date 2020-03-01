using System.Threading.Tasks;
using Partify.Core.Models;

namespace Partify.Core.Helpers
{
    public interface IYouTubeServiceWrapper
    {
        Task<YouTubeSongResult> GetVideo(string artist, string album, string song);
    }
}
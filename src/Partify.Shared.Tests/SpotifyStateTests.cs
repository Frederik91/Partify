using Partify.Shared.Helpers;
using Xunit;

namespace Partify.Shared.Tests
{
    public class SpotifyStateTests
    {
        [Fact]
        public void Deserialize()
        {
            var json = TestResources.SpotifyStateJson;
            var state = SpotifyStateSerializer.Deserialize(json);

            Assert.NotNull(state?.TrackWindow);
        }
    }
}

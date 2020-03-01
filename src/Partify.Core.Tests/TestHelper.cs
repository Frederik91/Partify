using System.IO;
using System.Reflection;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.Extensions.Configuration;
using Partify.Shared.Models;

namespace Partify.Shared.Tests
{
    public static class TestHelper
    {
        public static IConfigurationRoot GetIConfigurationRoot()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .AddJsonFile("appsettings.json", optional: true)
                .AddUserSecrets(typeof(TestHelper).Assembly)
                .AddEnvironmentVariables()
                .Build();
        }

        public static PartifyConfiguration GetApplicationConfiguration()
        {
            var configuration = new PartifyConfiguration();

            var iConfig = GetIConfigurationRoot();

            iConfig.Bind("Partify", configuration);

            return configuration;
        }

        public static YouTubeService GetYouTubeService(string apiKey)
        {
            return new YouTubeService(
                new BaseClientService.Initializer
                {
                    ApiKey = apiKey,
                    ApplicationName = "Partify"
                }
            );
        }
    }
}

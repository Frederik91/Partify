using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.LightInject;
using LightInject;
using Partify.Database.Services.Tracks;
using Partify.Database.Services.Videos;
using Partify.Shared.Services;

namespace Partify.Database
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.RegisterQueryHandlers();
            serviceRegistry.RegisterCommandHandlers();
            serviceRegistry.Register<ITrackService, TrackService>();
            serviceRegistry.Register<IVideoService, VideoService>();
        }
    }
}

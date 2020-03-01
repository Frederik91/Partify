using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LightInject;

namespace Partify.Server
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.RegisterFrom<Database.CompositionRoot>();
        }
    }
}

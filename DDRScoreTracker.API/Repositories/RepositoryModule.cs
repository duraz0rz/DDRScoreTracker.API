using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDRScoreTracker.API.Repositories
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SongRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}

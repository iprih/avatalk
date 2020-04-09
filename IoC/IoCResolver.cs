using Gama.RedeSocial.Infrastructure.CrossCutting.IoC.Containers;
using Gama.RedeSocial.Infrastructure.Persistence.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Gama.RedeSocial.Infrastructure.CrossCutting.IoC
{
    public class IoCResolver
    {
        private static IServiceCollection _services;

        private static IServiceProvider _provider;

        public static void RegisterContainers(IServiceCollection services, IServiceProvider provider)
        {
            _services = services;
            _provider = provider;

            new RepositoryContainer(_services);
            new ServiceContainer(_services);
            new ApplicationContainer(_services);

            RegisterMappers.Register();
        }

        public static T Resolve<T>()
        {
            return _provider.GetService<T>();
        }
    }
}

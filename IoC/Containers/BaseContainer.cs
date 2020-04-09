using Microsoft.Extensions.DependencyInjection;

namespace Gama.RedeSocial.Infrastructure.CrossCutting.IoC.Containers
{
    public class BaseContainer
    {
        private IServiceCollection _services;

        public BaseContainer(IServiceCollection services)
        {
            _services = services;
        }
    }
}

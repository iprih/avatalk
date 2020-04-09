using Gama.RedeSocial.Domain.Interfaces.Services;
using Gama.RedeSocial.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Gama.RedeSocial.Infrastructure.CrossCutting.IoC.Containers
{
    public class ServiceContainer : BaseContainer
    {
        public ServiceContainer(IServiceCollection services) : base(services)
        {
            services.AddSingleton<IGalleryService, GalleryService>();
            services.AddSingleton<IGenderService, GenderService>();
            services.AddSingleton<IInviteService, InviteService>();
            services.AddSingleton<IInviteStatusService, InviteStatusService>();
            services.AddSingleton<ILikeService, LikeService>();
            services.AddSingleton<IMidiaService, MidiaService>();
            services.AddSingleton<IMidiaTypeService, MidiaTypeService>();
            services.AddSingleton<IPostService, PostService>();
            services.AddSingleton<IUserService, UserService>();
        }
    }
}

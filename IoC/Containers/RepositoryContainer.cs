using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Gama.RedeSocial.Infrastructure.CrossCutting.IoC.Containers
{
    public class RepositoryContainer : BaseContainer
    {
        public RepositoryContainer(IServiceCollection services) : base(services)
        {
            services.AddSingleton<IGalleryRepository, GalleryRepository>();
            services.AddSingleton<IGenderRepository, GenderRepository>();
            services.AddSingleton<IInviteRepository, InviteRepository>();
            services.AddSingleton<IInviteStatusRepository, InviteStatusRepository>();
            services.AddSingleton<ILikeRepository, LikeRepository>();
            services.AddSingleton<IMidiaRepository, MidiaRepository>();
            services.AddSingleton<IMidiaTypeRepository, MidiaTypeRepository>();
            services.AddSingleton<IPostRepository, PostRespository>();
            services.AddSingleton<IUserRepository, UserRepository>();
        }
    }
}

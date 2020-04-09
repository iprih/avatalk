using Gama.RedeSocial.Application;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Microsoft.Extensions.DependencyInjection;

namespace Gama.RedeSocial.Infrastructure.CrossCutting.IoC.Containers
{
    public class ApplicationContainer : BaseContainer
    {
        public ApplicationContainer(IServiceCollection Applications) : base(Applications)
        {
            Applications.AddSingleton<IGalleryApplication, GalleryApplication>();
            Applications.AddSingleton<IGenderApplication, GenderApplication>();
            Applications.AddSingleton<IInviteApplication, InviteApplication>();
            Applications.AddSingleton<IInviteStatusApplication, InviteStatusApplication>();
            Applications.AddSingleton<ILikeApplication, LikeApplication>();
            Applications.AddSingleton<IMidiaApplication, MidiaApplication>();
            Applications.AddSingleton<IMidiaTypeApplication, MidiaTypeApplication>();
            Applications.AddSingleton<IPostApplication, PostApplication>();
            Applications.AddSingleton<IUserApplication, UserApplication>();
        }
    }
}

using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;

namespace Gama.RedeSocial.Application
{
    public class LikeApplication : ApplicationBase<Like>, ILikeApplication
    {
        private readonly ILikeService _service;

        public LikeApplication(ILikeService Service) : base(Service)
        {
            _service = Service;
        }
    }
}

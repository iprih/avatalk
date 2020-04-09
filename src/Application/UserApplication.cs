using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;

namespace Gama.RedeSocial.Application
{
    public class UserApplication : ApplicationBase<User>, IUserApplication
    {
        private readonly IUserService _service;

        public UserApplication(IUserService Service) : base(Service)
        {
            _service = Service;
        }
    }
}

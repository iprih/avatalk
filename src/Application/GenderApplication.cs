using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;

namespace Gama.RedeSocial.Application
{
    public class GenderApplication : ApplicationBase<Gender>, IGenderApplication
    {
        private readonly IGenderService _service;

        public GenderApplication(IGenderService Service) : base(Service)
        {
            _service = Service;
        }
    }
}

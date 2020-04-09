using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;

namespace Gama.RedeSocial.Application
{
    public class MidiaTypeApplication : ApplicationBase<MidiaType>, IMidiaTypeApplication
    {
        private readonly IMidiaTypeService _service;

        public MidiaTypeApplication(IMidiaTypeService Service) : base(Service)
        {
            _service = Service;
        }
    }
}

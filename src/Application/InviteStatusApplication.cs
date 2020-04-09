using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;

namespace Gama.RedeSocial.Application
{
    public class InviteStatusApplication : ApplicationBase<InviteStatus>, IInviteStatusApplication
    {
        private readonly IInviteStatusService _service;

        public InviteStatusApplication(IInviteStatusService Service) : base(Service)
        {
            _service = Service;
        }
    }
}

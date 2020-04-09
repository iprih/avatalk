using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;

namespace Gama.RedeSocial.Domain.Services
{
    public class InviteStatusService : ServiceBase<InviteStatus>, IInviteStatusService
    {
        private readonly IInviteStatusRepository _repository;

        public InviteStatusService(IInviteStatusRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}

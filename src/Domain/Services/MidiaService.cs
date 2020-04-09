using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;

namespace Gama.RedeSocial.Domain.Services
{
    public class MidiaService : ServiceBase<Midia>, IMidiaService
    {
        private readonly IMidiaRepository _repository;

        public MidiaService(IMidiaRepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}

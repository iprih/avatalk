using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;

namespace Gama.RedeSocial.Domain.Services
{
    public class MidiaTypeService : ServiceBase<MidiaType>, IMidiaTypeService
    {
        private readonly IMidiaTypeRepository _repository;

        public MidiaTypeService(IMidiaTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}

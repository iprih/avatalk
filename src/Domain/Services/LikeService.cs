using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;

namespace Gama.RedeSocial.Domain.Services
{
    public class LikeService : ServiceBase<Like>, ILikeService
    {
        private readonly ILikeRepository _repository;

        public LikeService(ILikeRepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}

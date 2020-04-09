using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;

namespace Gama.RedeSocial.Domain.Services
{
    public class GalleryService : ServiceBase<Gallery>, IGalleryService
    {
        private readonly IGalleryRepository _repository;

        public GalleryService(IGalleryRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Gallery GetFeedByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}

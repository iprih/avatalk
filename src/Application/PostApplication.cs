using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;

namespace Gama.RedeSocial.Application
{
    public class PostApplication : ApplicationBase<Post>, IPostApplication
    {
        private readonly IPostService _service;

        public PostApplication(IPostService Service) : base(Service)
        {
            _service = Service;
        }

        public Post BuscarPostPorID(Guid id)
        {
            return _service.BuscarPostPorID(id);
        }
    }
}

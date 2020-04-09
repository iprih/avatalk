using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;

namespace Gama.RedeSocial.Application
{
    public class GalleryApplication : ApplicationBase<Gallery>, IGalleryApplication
    {
        private readonly IGalleryService _service;

        public GalleryApplication(IGalleryService Service) : base(Service)
        {
            _service = Service;
        }
    }
}

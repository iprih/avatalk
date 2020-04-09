using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;

namespace Gama.RedeSocial.Application
{
    public class MidiaApplication : ApplicationBase<Midia>, IMidiaApplication
    {
        private readonly IMidiaService _service;

        public MidiaApplication(IMidiaService Service) : base(Service)
        {
            _service = Service;
        }

        public object GetAvatarByUserId(Guid userId, string webrootPath)
        {
            throw new NotImplementedException();
        }
    }
}

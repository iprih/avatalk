using Gama.RedeSocial.Domain.Entities;
using System;

namespace Gama.RedeSocial.Domain.Interfaces.Applications
{
    public interface IMidiaApplication : IApplicationBase<Midia>
    {
        object GetAvatarByUserId(Guid userId, string webrootPath);
    }
}

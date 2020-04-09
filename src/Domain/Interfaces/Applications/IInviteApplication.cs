using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Domain.Interfaces.Applications
{
    public interface IInviteApplication : IApplicationBase<Invite>
    {
        IEnumerable<Invite> GetByUserId(Guid userId);
    }
}

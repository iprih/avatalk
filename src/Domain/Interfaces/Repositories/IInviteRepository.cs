using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Domain.Interfaces.Repositories
{
    public interface IInviteRepository : IRepositoryBase<Invite>
    {
        IEnumerable<Invite> GetByUserId(Guid userId);
        IEnumerable<Invite> GetFriends(Guid userId);

    }
}

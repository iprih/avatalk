using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Interfaces.Repositories
{
    public interface IMidiaRepository : IRepositoryBase<Midia>
    {
        object GetAvatarByUserId(Guid userId);
    }
}

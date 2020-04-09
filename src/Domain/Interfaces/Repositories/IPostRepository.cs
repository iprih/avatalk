using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Domain.Interfaces.Repositories
{
    public interface IPostRepository : IRepositoryBase<Post>
    {
        Post BuscarPostPorID(Guid id);
        IEnumerable<Post> GetFeedByUserId(Guid userId);
    }
}

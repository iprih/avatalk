using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Domain.Interfaces.Services
{
    public interface IPostService : IServiceBase<Post>
    {
        Post BuscarPostPorID(Guid id);
        //IEnumerable<Post> GetFeedByUserId(Guid userId);
    }
}

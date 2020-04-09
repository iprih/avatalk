using Gama.RedeSocial.Domain.Entities;
using System;

namespace Gama.RedeSocial.Domain.Interfaces.Applications
{
    public interface IPostApplication : IApplicationBase<Post>
    {
        Post BuscarPostPorID(Guid id);
        //object GetFeedByUserId(Guid userId);
    }
}

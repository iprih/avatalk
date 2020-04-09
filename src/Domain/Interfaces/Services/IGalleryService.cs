using Gama.RedeSocial.Domain.Entities;
using System;

namespace Gama.RedeSocial.Domain.Interfaces.Services
{
    public interface IGalleryService : IServiceBase<Gallery>
    {
        Gallery GetFeedByUserId(Guid userId);
    }
}

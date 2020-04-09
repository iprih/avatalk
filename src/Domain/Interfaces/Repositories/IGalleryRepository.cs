using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Interfaces.Repositories
{
    public interface IGalleryRepository : IRepositoryBase<Gallery>
    {
        Gallery GetFeedByUserId(Guid userId);
    }
}

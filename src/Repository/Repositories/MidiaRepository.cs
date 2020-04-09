using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using System;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories
{
    public class MidiaRepository : RepositoryBase<Midia>, IMidiaRepository
    {
        public object GetAvatarByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}

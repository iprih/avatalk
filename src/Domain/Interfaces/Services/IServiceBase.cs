using Gama.RedeSocial.Domain.Entities;

namespace Gama.RedeSocial.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> : IBase<TEntity> 
        where TEntity : BaseEntity
    {
    }
}

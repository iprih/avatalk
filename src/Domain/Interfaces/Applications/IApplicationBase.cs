using Gama.RedeSocial.Domain.Entities;

namespace Gama.RedeSocial.Domain.Interfaces.Applications
{
    public interface IApplicationBase<TEntity> : IBase<TEntity> where TEntity : BaseEntity
    {
    }
}

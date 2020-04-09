using Dapper.FluentMap.Dommel.Mapping;
using Gama.RedeSocial.Domain.Entities;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository.Mappers
{
    public class BaseMapper<TEntity> : DommelEntityMap<TEntity> where TEntity : BaseEntity
    {
        public BaseMapper()
        {
            Map(entity => entity.Id).ToColumn("ID").IsKey();
            Map(e => e.DateCreated).ToColumn("DT_CREATED");
            Map(e => e.DateUpdated).ToColumn("DT_UPDATED");
            Map(e => e.Active).ToColumn("ST_ACTIVE");
        }
    }
}

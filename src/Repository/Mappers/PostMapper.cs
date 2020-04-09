using Gama.RedeSocial.Domain.Entities;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository.Mappers
{
    public class PostMapper : BaseMapper<Post>
    {
        public PostMapper()
        {
            ToTable("TB_POST");
            Map(e => e.Text).ToColumn("DS_TEXT");
            Map(e => e.ParentId).ToColumn("ID_PARENT");
            Map(e => e.AuthorId).ToColumn("ID_USER");
        }
    }
}

using Gama.RedeSocial.Domain.Entities;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository.Mappers
{
    public class UserMapper : BaseMapper<User>
    {
        public UserMapper()
        {
            ToTable("TB_USER");
            Map(entity => entity.Name).ToColumn("NM_USER");
            Map(entity => entity.Email).ToColumn("DS_EMAIL");
            Map(entity => entity.Password).ToColumn("DS_PASSWORD");
            Map(entity => entity.Birthday).ToColumn("DT_BIRTHDAY");
            Map(entity => entity.GenderId).ToColumn("ID_GENDER");
            Map(entity => entity.CoverId).ToColumn("ID_COVER");
            Map(entity => entity.AvatarId).ToColumn("ID_AVATAR");
        }
    }
}

using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using Gama.RedeSocial.Infrastructure.Persistence.Repository.Mappers;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository
{
    public static class RegisterMappers
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
                {
                    config.AddMap(new GalleryMapper());
                    config.AddMap(new GenderMapper());
                    config.AddMap(new InviteMapper());
                    config.AddMap(new InviteStatusMapper());
                    config.AddMap(new LikeMapper());
                    config.AddMap(new MidiaMapper());
                    config.AddMap(new MidiaTypeMapper());
                    config.AddMap(new PostMapper());
                    config.AddMap(new UserMapper());
                    config.ForDommel();
                }
            );
        }
    }
}

using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository.Mappers
{
    class LikeMapper : BaseMapper<Like>
    {
        public LikeMapper()
        {
            ToTable("TB_LIKES");
            Map(e => e.UserId).ToColumn("ID_USER");
            Map(e => e.PostId).ToColumn("ID_POST");
        }

    }
}

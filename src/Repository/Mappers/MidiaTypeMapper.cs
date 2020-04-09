using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository.Mappers
{
    public class MidiaTypeMapper : BaseMapper<MidiaType>
    {
        public MidiaTypeMapper()
        {
            ToTable("TB_MIDIA_TYPE");
            Map(entity => entity.Description).ToColumn("DS_MIDIA_TYPE");
            Map(entity => entity.Extensions).ToColumn("DS_EXTENSIONS");
        }
    }
}

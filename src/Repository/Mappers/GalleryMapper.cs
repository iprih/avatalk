using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository.Mappers
{
    public class GalleryMapper : BaseMapper<Gallery>
    {
        public GalleryMapper()
        {
            ToTable("TB_GALLERY");
            Map(entity => entity.AuthorId).ToColumn("ID_AUTHOR");
            Map(entity => entity.Name).ToColumn("NM_GALLERY");
        }
    }
}

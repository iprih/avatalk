using Dapper;
using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using System;
using System.Linq;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories
{
    public class GalleryRepository : RepositoryBase<Gallery>, IGalleryRepository
    {
        public Gallery GetFeedByUserId(Guid userId)
        {
            var sql = @"SELECT 
                        TB_GALLERY.*, 
                        TB_MIDIA.*, 
                        TB_MIDIA_TYPE.* 
                    FROM TB_MIDIA
                    INNER JOIN TB_MIDIA_GALLERY ON TB_MIDIA.ID = TB_MIDIA_GALLERY.ID_MIDIA
                    INNER JOIN TB_GALLERY ON TB_GALLERY.ID = TB_MIDIA_GALLERY.ID_GALLERY
                    INNER JOIN TB_USER ON TB_GALLERY.ID_USER = TB_USER.ID
                    INNER JOIN TB_MIDIA_TYPE ON TB_MIDIA_TYPE.ID = TB_MIDIA.ID_MIDIA_TYPE
                    WHERE 
                        TB_USER.ID = @userId AND
                        TB_GALLERY.NM_GALLERY = 'Feed'
                    ORDER BY TB_MIDIA.DT_CREATED";

            var parameters = new { userId = userId.ToString() };

            using (var cn = SqlConnectionFactory.Create())
            {
                return cn.Query<Gallery, Midia, MidiaType, Gallery>(sql, (gallery, midia, midiaType) =>
                {
                    midia.MidiaType = midiaType;

                    gallery.Midias.Add(midia);

                    return gallery;
                },
                splitOn: "ID",
                param: parameters).First();
            }
        }
    }
}

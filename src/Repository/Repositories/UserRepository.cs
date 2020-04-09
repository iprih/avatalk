using Dapper;
using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public IEnumerable<User> GetByName(string firstName)
        {
            var sql = "SELECT * FROM TB_USER WHERE NM_USER = @name";

            var parameters = new { name = firstName };

            return Execute<User>(sql, parameters);
        }

        public override User Get(Guid id)
        {
            var sql = @"select 
                    TB_USER.*,
                    TB_GENDER.*,
                    AVATAR.*,
                    COVER.*

                    from TB_USER

                    INNER JOIN TB_GENDER ON TB_USER.ID_GENDER = TB_GENDER.ID

                    INNER JOIN TB_MIDIA AS AVATAR ON TB_USER.ID_AVATAR = AVATAR.ID 

                    LEFT JOIN TB_MIDIA AS COVER ON TB_USER.ID_COVER = COVER.ID

                    WHERE TB_USER.ID = @id";

            using (var cn = SqlConnectionFactory.Create())
            {
                return cn.Query<User, Gender, Midia, Midia, User>(sql, (user, gender, avatar, cover) =>
                {
                    user.Gender = gender;

                    user.Avatar = avatar;

                    user.Cover = cover;

                    return user;
                },
                splitOn: "ID",
                param: new { id }).First();
            }
        }
    }
}

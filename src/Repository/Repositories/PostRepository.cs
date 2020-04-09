using Dapper;
using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories
{
    public class PostRespository : RepositoryBase<Post>, IPostRepository
    {
        public Post BuscarPostPorID(Guid id)
        {
            using (var cn = SqlConnectionFactory.Create())
            {
                var sql = @"SELECT 

                        TB_POST.*
                        ,TB_MIDIA.*
                        ,TB_MIDIA_TYPE.*
                        ,TB_LIKE.*
                        ,LIKE_USER.*
                        ,COMMENTS.*
                        ,AUTHOR.*

                        FROM TB_POST

                        LEFT JOIN TB_POST_MIDIA ON TB_POST.ID = TB_POST_MIDIA.ID_POST
                        
                        LEFT JOIN TB_MIDIA ON TB_POST_MIDIA.ID_MIDIA = TB_MIDIA.ID
                        
                        LEFT JOIN TB_MIDIA_TYPE ON TB_MIDIA.ID_MIDIA_TYPE = TB_MIDIA_TYPE.ID
                        
                        LEFT JOIN TB_LIKE ON TB_POST.ID = TB_LIKE.ID_POST
                        
                        LEFT JOIN TB_USER ON TB_LIKE.ID_USER = TB_USER.ID
                        
                        LEFT JOIN TB_USER AS LIKE_USER ON LIKE_USER.ID = TB_LIKE.ID_USER
                        
                        LEFT JOIN TB_POST AS COMMENTS ON TB_POST.ID_PARENT = COMMENTS.ID
                        
                        LEFT JOIN TB_USER AS AUTHOR ON TB_POST.ID_USER = AUTHOR.ID
                        
                        LEFT JOIN TB_USER AS AUTHOR_COMMENT ON COMMENTS.ID_USER = AUTHOR_COMMENT.ID

                        WHERE TB_POST.ID = @id";

                return cn.Query<Post, Midia, MidiaType, Like, User, Post, User, Post>
                    (sql, (post, midia, midiatype, like, likeUser, comment, author) =>
                    {
                        if (midia != null)
                        {
                            midia.MidiaType = midiatype;
                            midia.MidiaTypeId = midiatype.Id;
                            post.Midias.Add(midia);
                        }

                        if (comment != null)
                        {
                            post.Comments.Add(comment);
                        }

                        if (like != null)
                        {
                            //likeUser.Cover = null;
                            //likeUser.CoverId = null;
                            //likeUser.Avatar = null;
                            like.User = likeUser;
                            like.UserId = likeUser.Id;
                            like.Post = null;
                            post.Likes.Add(like);
                        }

                        post.Author = author;
                        post.AuthorId = author.Id;

                        return post;

                    },
                    splitOn: "ID",
                    param: new { id })
                    .First();
            }
        }

        public IEnumerable<Post> GetFeedByUserId(Guid userId)
        {
            var sql = @"SELECT * FROM TB_POST
                        WHERE
	                        TB_POST.ID_USER = @userId OR
	                        TB_POST.ID_USER in 
                        ( 
	                        SELECT ID_SENDER from TB_INVITE 
	                        INNER JOIN TB_INVITE_STATUS on TB_INVITE.ID_INVITE_STATUS = TB_INVITE_STATUS.ID
	                        WHERE DS_INVITE_STATUS = 'Aceito' AND ID_RECEIVER = @userId 

	                        UNION

	                        SELECT ID_RECEIVER from TB_INVITE 
	                        INNER JOIN TB_INVITE_STATUS on TB_INVITE.ID_INVITE_STATUS = TB_INVITE_STATUS.ID
	                        WHERE DS_INVITE_STATUS = 'Aceito' AND ID_SENDER = @userId 
                        )
                        ORDER BY DT_UPDATED DESC";

            using (var cn = SqlConnectionFactory.Create())
            {
                var result = cn.Query<Post>(sql, new { userId });

                return result;
            }
        }
        //public void InserirPost(Post post)
        //{
        //    using(var cn = SqlConnectionFactory.Create())
        //    {
        //        // var sql = @"Insert INTO TB_POST (ParentId, Author, Text)Values(@ParentId, @Author, @Text);";

        //         var sql = @"Insert INTO TB_POST (ParentId, Author, Text)Values("+post.ParentId +", "+post.AuthorId+","+post.Text +" );";


        //        /*var parameters = new List<Parameter>() {
        //        new Parameter("@ParentId", DbType.Guid, post.ParentId),
        //        new Parameter("@Author", DbType.Guid, post.Author.Id),
        //        new Parameter(" @Text", DbType.String, post.Text) };
        //        */
        //        Post resultPost = cn.ExecuteScalar<Post>(sql, null);
        //    }
        //}
           
         
    }
    
}

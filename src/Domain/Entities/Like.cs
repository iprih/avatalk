
using System;

namespace Gama.RedeSocial.Domain.Entities
{
    public class Like : BaseEntity
    {
        public Like()
        {
            Post = new Post();

            User = new User();
        }


        public Guid PostId{ get; set; }
        public Post Post { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public override void Validate()
        {
            if (PostId == Guid.Empty)
                throw new ArgumentNullException("'PostId' não foi preenchido");

            if (UserId == Guid.Empty)
                throw new ArgumentNullException("'UserId' não foi preenchido");

        }
    }
}

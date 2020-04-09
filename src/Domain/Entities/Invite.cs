using System;

namespace Gama.RedeSocial.Domain.Entities
{
    public class Invite : BaseEntity
    {
        public Invite()
        {
            Sender = new User();

            Receiver = new User();

            InviteStatus = new InviteStatus();
        }


        public Guid SenderId { get; set; }
        public User Sender { get; set; }

        public Guid ReceiverId { get; set; }
        public User Receiver { get; set; }

        public Guid InviteStatusId { get; set; }
        public InviteStatus InviteStatus { get; set; }

        public override void Validate()
        {
            if(SenderId == Guid.Empty)
                throw new ArgumentNullException("'SenderId' não foi preenchido");

            if (ReceiverId == Guid.Empty)
                throw new ArgumentNullException("'ReceiverId' não foi preenchido");

            if (InviteStatusId == Guid.Empty)
                throw new ArgumentNullException("'InviteStatusId' não foi preenchido");


            if(SenderId == ReceiverId)
                throw new ArgumentException("Invite inválido");

        }
    }
}

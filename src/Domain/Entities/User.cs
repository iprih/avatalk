using System;
using System.Text.RegularExpressions;

namespace Gama.RedeSocial.Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Gender = new Gender();
            Cover = new Midia();
            Avatar = new Midia();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }

        public Guid GenderId { get; set; }
        public Gender Gender { get; set; }

        public Guid CoverId { get; set; }
        public Midia Cover { get; set; }

        public Guid AvatarId { get; set; }
        public Midia Avatar { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException("'Name' não foi preenchido");

            if (String.IsNullOrWhiteSpace(Email))
                throw new ArgumentNullException("'Email' não foi preenchido");

            if (!Regex.Match(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
                throw new ArgumentException("'Email' é inválido");

            if (String.IsNullOrWhiteSpace(Password))
                throw new ArgumentNullException("'Name' não foi preenchido");

            if (Password.Length < 8)
                throw new ArgumentException("'Password' menor que 8 caracteres");

            if (Birthday == null)
                throw new ArgumentNullException("'Birthday' não foi preenchido");

            if (Birthday == DateTime.MinValue)
                throw new ArgumentException("'Birthday' é inválido");

            if (GenderId == Guid.Empty)
                throw new ArgumentNullException("'GenderId' não foi preenchido");

            if (CoverId == Guid.Empty)
                throw new ArgumentNullException("'CoverId' não foi preenchido");

            if (AvatarId == Guid.Empty)
                throw new ArgumentNullException("'AvatarId' não foi preenchido");
        }
    }
}

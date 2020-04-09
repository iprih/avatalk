using System;

namespace Gama.RedeSocial.Domain.Entities
{
    public class MidiaType : BaseEntity
    {
        public string Description { get; set; }
        public string Extensions { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrWhiteSpace(Description))
                throw new ArgumentNullException("'Description' não foi preenchido");

            if (String.IsNullOrWhiteSpace(Extensions))
                throw new ArgumentNullException("'Extensions' não foi preenchido");
        }
    }
}

using System;

namespace Gama.RedeSocial.Domain.Entities
{
    public class Midia : BaseEntity
    {
        public Midia()
        {
            MidiaType = new MidiaType();
        }

        public string Description { get; set; }
        public Guid MidiaTypeId { get; set; }
        public MidiaType MidiaType { get; set; }

        public string Path { get; set; }

        public override void Validate()
        {
            if(MidiaTypeId == Guid.Empty)
                throw new ArgumentNullException("'MidiaTypeId' não foi preenchido");

            if (String.IsNullOrWhiteSpace(Path))
                throw new ArgumentNullException("'Path' não foi preenchido");
        }
    }
}

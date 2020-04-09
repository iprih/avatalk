using System;

namespace Gama.RedeSocial.Domain.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();

            DateCreated = DateTime.Now;

            DateUpdated = DateTime.Now;

            Active = true;
        }

        public Guid Id { get; set; }
        public DateTime DateCreated  { get; set; }
        public DateTime DateUpdated  { get; set; }
        public bool Active { get; set; }

        public abstract void Validate();
    }
}

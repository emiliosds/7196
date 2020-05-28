using System;

namespace Todo.Domain.Entities
{
    //IEquatable - Facilita a comparação de entre objetos. Isso acontece através do método Equals
    public abstract class Entity : IEquatable<Entity>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }
    }
}
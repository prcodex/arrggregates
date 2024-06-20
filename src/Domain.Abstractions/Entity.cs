using Arrggregates.Domain.Contracts;

namespace Arrggregates.Domain.Abstractions
{
    public abstract class Entity
       : IEntity, IEquatable<Entity>, IEqualityComparer<Entity>
    {
        public virtual Guid Id { get; protected set; }

        public override bool Equals(object? obj)
        {
            if (obj is not Entity)
            { return false; }

            if (ReferenceEquals(this, obj))
            { return true; }

            if (GetType() != obj.GetType())
            { return false; }

            var item = (Entity)obj;
            return item.Id == Id;
        }

        public bool Equals(Entity? other)
            => Equals((object?)other);

        public bool Equals(Entity? x, Entity? y)
            => x == y;

        public override int GetHashCode()
            => Id.GetHashCode() ^ 31;

        public int GetHashCode(Entity obj)
            => obj.GetHashCode();

        public static bool operator ==(Entity? left, Entity? right)
            => left is null ? right is null : left.Equals(right);

        public static bool operator !=(Entity? left, Entity? right)
            => !(left == right);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.Domain.Common.Models
{
    public abstract class Entity<T> : IEquatable<Entity<T>> where T : ValueObject
    {

        public T Id { get; private set; }
        public Entity(T id)
        {
            Id = id;

        }
        protected Entity()
        {

        }
        public override bool Equals(object? obj)
        {
            return obj is Entity<T> entity && Id.Equals(entity.Id);
        }

        public bool Equals(Entity<T>? other)
        {
            return Equals((object?)other);
        }

        public static bool operator ==(Entity<T> left, Entity<T> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Entity<T> left, Entity<T> right)
        {
            return !Equals(left, right);
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

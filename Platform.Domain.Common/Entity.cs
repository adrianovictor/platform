using System;

namespace Platform.Domain.Common
{
    public abstract class Entity<TEntity> : IEntity<TEntity>
        where TEntity : class
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public bool IsPersisted() 
        {
            return !IsTransient();
        }

        protected virtual bool IsTransient() 
        {
            return Id == 0;
        }
    }
}
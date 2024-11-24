using System;

namespace SubtypeCovariance
{
    // Generic repository implementation
    public class Repository<TEntity> : IEntityRepository<TEntity>
        where TEntity : Entity
    {
        public TEntity GetByID(Guid id)
        {
            return (TEntity)Activator.CreateInstance(typeof(TEntity), id);
        }
    }
}

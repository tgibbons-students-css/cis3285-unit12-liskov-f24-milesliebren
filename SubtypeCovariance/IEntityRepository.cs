using System;

namespace SubtypeCovariance
{
    public interface IEntityRepository<TEntity>
        where TEntity : Entity
    {
        TEntity GetByID(Guid id);
    }
}

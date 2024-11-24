using System;

namespace SubtypeCovariance
{
    public class EntityRepository : IEntityRepository<Entity>
    {
        public virtual Entity GetByID(Guid id)
        {
            return new Entity(id);
        }
    }
}
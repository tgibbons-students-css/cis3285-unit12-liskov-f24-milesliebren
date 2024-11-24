using System;

namespace SubtypeCovariance
{
    public interface IUserRepository : IEntityRepository<Entity>
    {
        User GetByID(Guid id);
    }
}

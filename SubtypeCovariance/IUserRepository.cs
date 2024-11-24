using System;

namespace SubtypeCovariance
{
    public interface IUserRepository : IEntityRepository
    {
        User GetByID(Guid id);
    }
}

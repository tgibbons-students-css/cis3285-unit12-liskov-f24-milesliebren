using System;

namespace SubtypeCovariance
{
    public class UserRepository : IEntityRepository<User>
    {
        public User GetByID(Guid id)
        {
            return new User(id);
        }
    }
}

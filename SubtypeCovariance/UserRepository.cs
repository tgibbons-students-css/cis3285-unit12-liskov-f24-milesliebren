using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public class UserRepository : IEntityRepository<User>
    {
        User IEntityRepository<User>.GetByID(Guid id)
        {
            return new User(id);
        }
    }
}

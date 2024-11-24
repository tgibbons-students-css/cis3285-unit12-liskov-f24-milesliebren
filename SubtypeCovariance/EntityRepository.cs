using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public class EntityRepository : IEntityRepository
    {
        public virtual Entity GetByID(Guid id)
        {
            return new Entity(id);
        }
    }
}

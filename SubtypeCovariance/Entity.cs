using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public class Entity
    {
        public Entity(Guid newID)
        {
            ID = newID;
        }

        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}

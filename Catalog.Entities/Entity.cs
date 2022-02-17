using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Entities
{
    public abstract class Entity
    {
        // Global Unique Identifier
        // Evrensel Benzersiz Kimlik No
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

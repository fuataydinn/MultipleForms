using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Entities
{
    public class Product : Entity
    {
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
}

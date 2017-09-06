using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Core.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }

        public string ProductType { get; set; }
    }
}

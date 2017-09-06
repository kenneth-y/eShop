using eShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Core.Interfaces
{
    public interface IProductService
    {
        int RegisterProduct(int id, string name, string type);
        bool UpdateProduct(int id, string name, string type);
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts(int id, string name, string type);
        bool DeleteProduct(int id);
    }
}

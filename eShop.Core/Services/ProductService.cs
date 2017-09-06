using eShop.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShop.Core.Models;

namespace eShop.Core.Services
{
    public class ProductService : IProductService
    {
        public ProductService(IRepository<Entities.Product> productRepository)
        {
            _productRepository = productRepository;
        }

        private IRepository<Entities.Product> _productRepository;

        public bool DeleteProduct(int id)
        {
            return _productRepository.Delete(id);
        }

        public Product GetProduct(int id)
        {
            var productEntity = _productRepository.GetById(id);
            return MapProductEntityToModel(productEntity);
        }

        public IEnumerable<Product> GetProducts(int id, string name, string type)
        {
            var listOfProducts = new List<Product>();
            var productEntities = _productRepository.Find();
            productEntities
                .ToList()
                .ForEach(p => listOfProducts.Add(MapProductEntityToModel(p)));

            return listOfProducts;
        }

        public int RegisterProduct(int id, string name, string type)
        {
            var productEntity = _productRepository.Add(new Entities.Product
            {
                Id = id,
                Name = name,
                ProductType = type
            });
            return (productEntity != null) ? 1 : 0;
        }

        public bool UpdateProduct(int id, string name, string type)
        {
            return _productRepository.Update(new Entities.Product
            {
                Id = id,
                Name = name,
                ProductType = type
            });
        }

        private Product MapProductEntityToModel(Entities.Product productEntity)
        {
            return new Product
            {
                Id = productEntity.Id,
                Name = productEntity.Name,
                ProductType = productEntity.ProductType
            };
        }
    }
}

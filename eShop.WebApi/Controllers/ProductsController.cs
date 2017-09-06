using eShop.Core.Interfaces;
using eShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eShop.WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        private IProductService _productService;

        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            return _productService.GetProducts(0, null, null);
        }

        // GET: api/Products/5
        public Product Get(int id)
        {
            return _productService.GetProduct(id);
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}

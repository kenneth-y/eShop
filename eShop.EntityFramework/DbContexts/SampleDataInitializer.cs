using eShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.EntityFramework.DbContexts
{
    public class SampleDataInitializer : DropCreateDatabaseIfModelChanges<EShopDbContext>
    {
        protected override void Seed(EShopDbContext context)
        {
            var products = new List<Product>
            {
                new Product { Name = "Pantene", ProductType = "Shampoo" },
                new Product { Name = "Colgate", ProductType = "Toothpaste" }
            };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}

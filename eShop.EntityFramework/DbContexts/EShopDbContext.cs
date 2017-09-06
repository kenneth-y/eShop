using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using eShop.Core.Entities;

namespace eShop.EntityFramework.DbContexts
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext() : base("eShopDbContext")
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

using eShop.Core.Entities;
using eShop.Core.Interfaces;
using eShop.EntityFramework.DbContexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.EntityFramework.Repositories
{
    public class SqlStoreRepository<T> : IRepository<T> where T : EntityBase
    {
        public SqlStoreRepository(EShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        private readonly EShopDbContext _eShopDbContext;

        public T Add(T entity)
        {
            _eShopDbContext.Set<T>().Add(entity);
            _eShopDbContext.SaveChanges();

            return entity;
        }

        public bool Delete(T entity)
        {
            _eShopDbContext.Set<T>().Remove(entity);
            int rowsAffected = _eShopDbContext.SaveChanges();
            return (rowsAffected > 0);
        }

        public bool Delete(int id)
        {
            var entityToDelete = _eShopDbContext.Set<T>().SingleOrDefault(i => i.Id == id);
            return Delete(entityToDelete);
        }

        public IEnumerable<T> Find()
        {
            return _eShopDbContext.Set<T>().AsEnumerable();
        }

        public T GetById(int id)
        {
            return _eShopDbContext.Set<T>().SingleOrDefault(i => i.Id == id);
        }

        public bool Update(T entity)
        {
            _eShopDbContext.Entry(entity).State = EntityState.Modified;
            return _eShopDbContext.SaveChanges() > 0;
        }
    }
}

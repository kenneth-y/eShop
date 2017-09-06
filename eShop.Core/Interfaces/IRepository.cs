using eShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Core.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetById(int id);
        IEnumerable<T> Find();
        // IEnumerable<T> Find(ISpecification spec);
        T Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
        bool Delete(T entity);
    }
}

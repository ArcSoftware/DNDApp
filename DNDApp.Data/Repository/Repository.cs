using System;
using System.Linq;
using System.Linq.Expressions;
using DNDApp.Common.Interfaces;

namespace DNDApp.Data.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public IQueryable<T> GetItems<T>(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DNDApp.Common.Interfaces;

namespace DNDApp.Data.Repository
{
    public class Repository : IRepository
    {
        private readonly DNDContext _context; 
        public Repository(DNDContext dndContext)
        {
            _context = dndContext;
        }

        public T GetItem<T>(Expression<Func<T, bool>> predicate = null) where T : class
        {
            return GetItems(predicate).FirstOrDefault();
        }

        public IEnumerable<T> GetItems<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            IQueryable<T> query = _context.Set<T>();

            var results = query.Where(predicate);

            return results;
        }

        public void Create<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
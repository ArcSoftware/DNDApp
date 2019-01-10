using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DNDApp.Common.Interfaces;

namespace DNDApp.Data.Repository
{
    public class Repository : IRepository
    {
        private readonly DNDContext context; 
        public Repository(DNDContext dndContext)
        {
            context = dndContext;
        }

        public IEnumerable<T> GetItems<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            IQueryable<T> query = context.Set<T>();

            var results = query.Where(predicate);

            return results;
        }

        public void Add<T>(T entity) where T : class
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
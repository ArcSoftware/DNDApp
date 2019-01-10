using System;
using System.Collections;
using System.Linq.Expressions;
using DNDApp.Common.Interfaces;

namespace DNDApp.Data.Repository
{
    public abstract class Repository : IRepository
    {
        public IEnumerable GetItems<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            throw new NotImplementedException();
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
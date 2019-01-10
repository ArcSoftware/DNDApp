using System;
using System.Linq;
using System.Linq.Expressions;

namespace DNDApp.Common.Interfaces
{
    public interface IRepository
    {
        IQueryable<T> GetItems<T>(Expression<Func<T, bool>> predicate) where T : class;

        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class; 
    }
}
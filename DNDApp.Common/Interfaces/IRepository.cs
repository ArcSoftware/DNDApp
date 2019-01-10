using System;
using System.Collections;
using System.Linq.Expressions;

namespace DNDApp.Common.Interfaces
{
    public interface IRepository
    {
        IEnumerable GetItems<T>(Expression<Func<T, bool>> predicate) where T : class;

        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class; 
    }
}
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DNDApp.Common.Interfaces
{
    public interface IRepository
    {
        T GetItem<T>(Expression<Func<T, bool>> predicate = null) where T : class; 

        IEnumerable<T> GetItems<T>(Expression<Func<T, bool>> predicate = null) where T : class;

        void Create<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class; 
    }
}
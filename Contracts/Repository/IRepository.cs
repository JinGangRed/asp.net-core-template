using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Contracts.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> FindAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        void Create(T entity);

        void CreateRange(IEnumerable<T> entities);

        void Edit(T entity);

        void Delete(T entity);

        void Save();
    }
}

using Contracts.Repository;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected RepositoryContext RepositoryContext;
        public Repository(RepositoryContext RepositoryContext)
        {
            this.RepositoryContext = RepositoryContext;
        }
        public void Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
        }

        public void CreateRange(IEnumerable<T> entities)
        {
            RepositoryContext.Set<T>().AddRange(entities);
        }

        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression) => RepositoryContext.Set<T>().Where(expression);

        public IEnumerable<T> FindAll()
        {
            return RepositoryContext.Set<T>();
        }

        public void Save()
        {
            RepositoryContext.SaveChanges();
        }
    }
}

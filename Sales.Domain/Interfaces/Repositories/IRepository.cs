using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sales.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        public void Add(TEntity obj);
        public void Remove(TEntity obj);
        public void Update(TEntity obj);
        public TEntity GetById(int id);
        public IEnumerable<TEntity> Find(Expression<Func<bool, TEntity>> predicate);
    }
}

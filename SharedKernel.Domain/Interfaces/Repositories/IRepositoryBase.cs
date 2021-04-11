using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SharedKernel.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        public void Add(TEntity obj);
        public void Update(TEntity obj);
        public void Delete(TEntity obj);
        public TEntity GetById(int id);
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SharedKernel.Application.Interfaces
{
    public interface IServiceAppBase<TEntity> : IDisposable where TEntity : class
    {
        public void Add(TEntity obj);
        public void Update(TEntity obj);
        public void Delete(TEntity obj);
        public TEntity GetById(int id);
        public IEnumerable<TEntity> GetAll();
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}

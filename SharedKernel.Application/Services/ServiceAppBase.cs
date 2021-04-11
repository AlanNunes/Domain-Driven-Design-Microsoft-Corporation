using SharedKernel.Application.Interfaces;
using SharedKernel.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SharedKernel.Application.Services
{
    public class ServiceAppBase<TEntity> : IServiceAppBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repositoryBase;
        public ServiceAppBase(IRepositoryBase<TEntity> repositoryBase)
        {
            this.repositoryBase = repositoryBase;
        }
        public void Add(TEntity obj)
        {
            this.repositoryBase.Add(obj);
        }

        public void Delete(TEntity obj)
        {
            this.repositoryBase.Delete(obj);
        }

        public void Dispose()
        {
            this.repositoryBase.Dispose();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return this.repositoryBase.Find(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.repositoryBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return this.repositoryBase.GetById(id);
        }

        public void Update(TEntity obj)
        {
            this.repositoryBase.Update(obj);
        }
    }
}

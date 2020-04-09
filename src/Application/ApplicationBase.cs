using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Gama.RedeSocial.Application
{
    public class ApplicationBase<TEntity> : IApplicationBase<TEntity> where TEntity : BaseEntity
    {
        private readonly IServiceBase<TEntity> _service;

        public ApplicationBase(IServiceBase<TEntity> service)
        {
            _service = service;
        }

        public bool Delete(Guid id)
        {
            return _service.Delete(id);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _service.Get(predicate);
        }

        public TEntity Get(Guid id)
        {
            return _service.Get(id);
        }

        public Guid Insert(TEntity entity)
        {
            return _service.Insert(entity);
        }

        public bool Update(TEntity entity)
        {
            return _service.Update(entity);
        }
    }
}

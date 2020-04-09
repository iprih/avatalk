using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Gama.RedeSocial.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : BaseEntity
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public bool Delete(Guid id)
        {
            if (id == new Guid()) throw new ArgumentNullException("O Id deve ser preenchido");

            return _repository.Delete(id);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.Get(predicate);
        }

        public TEntity Get(Guid id)
        {
            return _repository.Get(id);
        }

        public Guid Insert(TEntity entity)
        {
            entity.Validate();

            return _repository.Insert(entity);
        }

        public bool Update(TEntity entity)
        {
            entity.Validate();

            return _repository.Update(entity);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Estoque.DAL
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Find(ulong id);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        bool Any(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void Remove(ulong id);
        void RemoveEntities(IEnumerable<TEntity> entities);
        void Update(TEntity entity);

    }
}

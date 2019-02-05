using Estoque.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Common.RepositoryPattern
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        SelectList CreateSelectList(long id);
        TEntity Find(long id);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        bool Any(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void Remove(long id);
        void RemoveEntities(IEnumerable<TEntity> entities);
        void Update(TEntity entity);

        Task<List<TEntity>> ToListAsync();
        Task<Entity> FirstOrDefaultAsync(Expression<Func<Entity, bool>> predicate);
        Task<TEntity> FindAsync(long? id);

    }
}

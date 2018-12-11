using Estoque.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Estoque.DAL.InterfacesRepository
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        TEntity Find(long id);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        bool Any(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<ValidationResult> Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void Remove(long id);
        void RemoveEntities(IEnumerable<TEntity> entities);
        IEnumerable<ValidationResult> Update(TEntity entity);

        Task<List<TEntity>> ToListAsync();
        Task<Entity> FirstOrDefaultAsync(Expression<Func<Entity, bool>> predicate);
        Task<TEntity> FindAsync(long? id);

    }
}

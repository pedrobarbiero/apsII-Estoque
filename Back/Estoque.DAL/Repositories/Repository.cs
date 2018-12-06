using Estoque.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Estoque.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {

        protected readonly DbContext Context;
        private DbSet<TEntity> _dbSet;
        protected IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate) {
            if (predicate != null)
                return _dbSet.Where(predicate);
            else
                return _dbSet;
        }

        public Repository(DbContext context)
        {
            Context = context;
            _dbSet = context.Set<TEntity>();
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Query(predicate).SingleOrDefault(predicate);
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return Query(predicate).Any(predicate);
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public TEntity Find(ulong id)
        {
            return Query(null).FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<TEntity> Get()
        {
            return Query(null).ToList();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return Query(predicate).ToList();
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
        
        public void RemoveEntities(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(ulong id)
        {
            var entity = (TEntity)Activator.CreateInstance(typeof(TEntity));
            (entity as TEntity).Id = id;
            _dbSet.Attach(entity);
            _dbSet.Remove(entity);
        }
    }
}

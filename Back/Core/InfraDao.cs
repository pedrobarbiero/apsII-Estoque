using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infra.Infra
{
    public abstract class InfraDao<T> where T: InfraEntity
    {
        public virtual IQueryable<T> Query(DbContext context)
        {
            return context.Set<T>();
        }
        public virtual void Add(DbContext context, T entity)
        {
            context.Entry(entity).State = EntityState.Added;
        }

        public virtual void Update(DbContext context, T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(DbContext context, T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
        }
    }
}

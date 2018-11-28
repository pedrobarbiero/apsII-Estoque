using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Infra
{
    public abstract class InfraService<T> : IDisposable where T : InfraEntity
    {
        protected InfraDao<T> Dao { get; set; }

        protected DbContext Context { get; set; }


        public InfraService(InfraDao<T> dao, DbContext context)
        {
            this.Dao = dao;
            this.Context = context;
        }

        public virtual T Find(long id)
        {            
            return Dao.Query(this.Context).AsNoTracking().FirstOrDefault(x => x.Id == id);            
        }

        public virtual IDictionary<string, string> Validate(T entity)
        {
            return new Dictionary<string, string>(); //TODO implementar validacao generica
        }
        public virtual IDictionary<string, string> Add(T entity)
        {
            var messages = Validate(entity);
            if (!messages.Any())
                this.Dao.Add(this.Context, entity);
            return messages;
        }

        public virtual IDictionary<string, string> Update(DbContext context, T entity)
        {
            var messages = Validate(entity);
            if (!messages.Any())
                this.Dao.Update(context, entity);
            return messages;
        }

        public virtual void Delete(DbContext context, T entity)
        {
            this.Dao.Delete(context, entity);
        }


        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

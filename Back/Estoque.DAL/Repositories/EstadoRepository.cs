using Estoque.DAL.InterfacesRepository;
using Estoque.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Estoque.DAL.Repositories
{
    public class EstadoRepository : Repository<Estado>, IEstadoRepository
    {
        public EstadoRepository(DbContext context) : base(context)
        {
        }

        protected override IQueryable<Estado> Query(Expression<Func<Estado, bool>> predicate)
        {
            var query = base.Query(predicate);
            return query.Include(t => t.Pais);
        }
        
    }
}

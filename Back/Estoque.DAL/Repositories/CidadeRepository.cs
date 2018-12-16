using System;
using System.Linq;
using System.Linq.Expressions;
using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
using Microsoft.EntityFrameworkCore;

namespace Estoque.DAL.Repositories
{
    public class CidadeRepository : Repository<Cidade>, ICidadeRepository
    {
        protected override IQueryable<Cidade> Query(Expression<Func<Cidade, bool>> predicate)
        {
            return base.Query(predicate).Include(t => t.Estado);
        }
        public CidadeRepository(DbContext context) : base(context)
        {
        }
    }
}

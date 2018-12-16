using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Estoque.DAL.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(DbContext context) : base(context)
        {
        }

        protected override IQueryable<Endereco> Query(Expression<Func<Endereco, bool>> predicate)
        {
            var query = base.Query(predicate);
            return query.Include(t => t.Cidade);
        }

    }
}

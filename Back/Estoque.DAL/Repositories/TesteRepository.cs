using Estoque.DAL.Context;
using Estoque.DAL.Entities;
using System;

namespace Estoque.DAL.Repositories
{
    public class TesteRepository : Repository<Teste>, ITesteRepository
    {
        public TesteRepository(TesteContext context) : base(context)
        {

        }
        public string TesteDescricao()
        {
            return "testando som 1..2..3..";
        }
    }
}

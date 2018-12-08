using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
using Microsoft.EntityFrameworkCore;

namespace Estoque.DAL.Repositories
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(DbContext context) : base(context)
        {
        }
    }
}

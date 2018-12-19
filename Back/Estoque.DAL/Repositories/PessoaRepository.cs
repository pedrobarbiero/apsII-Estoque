using Comon.RepositoryPattern;
using Estoque.DAL.InterfacesRepository;
using Estoque.Entities;
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

using Comon.RepositoryPattern;
using Estoque.DAL.InterfacesRepository;
using Estoque.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estoque.DAL.Repositories
{
    public class PessoaJuridicaRepository : Repository<PessoaJuridica>, IPessoaJuridicaRepository
    {
        public PessoaJuridicaRepository(DbContext context) : base(context)
        {
        }
    }
}

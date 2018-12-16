using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
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

using Estoque.DAL.InterfacesRepository;
using Estoque.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estoque.DAL.Repositories
{
    public class PessoaFisicaRepository : Repository<PessoaFisica>, IPessoaFisicaRepository
    {
        public PessoaFisicaRepository(DbContext context) : base(context)
        {
        }
    }
}

using Estoque.Entities;
using Estoque.DAL.InterfacesRepository;
using Microsoft.EntityFrameworkCore;

namespace Estoque.DAL.Repositories
{
    public class TelefoneRepository : Repository<Telefone>, ITelefoneRepository
    {
        public TelefoneRepository(DbContext context) : base(context)
        {
        }
    }
}

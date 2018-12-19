using Comon.RepositoryPattern;
using Estoque.DAL.InterfacesRepository;
using Estoque.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estoque.DAL.Repositories
{
    public class PaisRepository : Repository<Pais>, IPaisRepository
    {
        public PaisRepository(DbContext context) : base(context)
        {
        }
    }
}

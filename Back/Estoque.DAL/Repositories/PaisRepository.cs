using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
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

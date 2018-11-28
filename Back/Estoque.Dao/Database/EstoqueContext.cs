using Microsoft.EntityFrameworkCore;

namespace Estoque.Dao.Database
{
    public class EstoqueContext: DbContext
    {
        public EstoqueContext(DbContextOptions<DbContext> options) : base(options)
        {

        }
    }
}

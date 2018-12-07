using Estoque.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estoque.DAL.Context
{
    public class TesteContext : DbContext
    {
        public DbSet<Teste> Testes { get; set; }

        public TesteContext(DbContextOptions<TesteContext> options) : base(options)
        {
        }
    }
}

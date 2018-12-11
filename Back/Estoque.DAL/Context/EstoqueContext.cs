using Estoque.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estoque.DAL.Context
{
    public class EstoqueContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }

        public EstoqueContext(DbContextOptions<EstoqueContext> options) : base(options)
        { ///TODO validações
        }
    }
}

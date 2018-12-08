using Estoque.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estoque.DAL.Context
{
    public class EstoqueContext : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }

        public EstoqueContext(DbContextOptions<EstoqueContext> options) : base(options)
        {
        }
    }
}

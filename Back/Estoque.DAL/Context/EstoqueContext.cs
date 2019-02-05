using Estoque.Entities;
using Estoque.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estoque.DAL.Context
{
    public class EstoqueContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Endereco> Enderecos{ get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }

        public EstoqueContext(DbContextOptions<EstoqueContext> options) : base(options)
        {
        }
    }
}

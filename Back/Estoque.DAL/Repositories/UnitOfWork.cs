using Estoque.DAL.Context;
using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
using System.Threading.Tasks;

namespace Estoque.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EstoqueContext _context;
        public UnitOfWork(EstoqueContext context)
        {
            _context = context;
            PessoaRepository = new PessoaRepository(_context);
        }

        public IPessoaRepository PessoaRepository { get; private set; }
        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {       
            return _context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }     

    }
}

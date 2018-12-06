using Estoque.DAL.Context;
using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;

namespace Estoque.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TesteContext _context;
        public UnitOfWork(TesteContext context)
        {
            _context = context;
            TesteDetalhes = new TesteDetalheRepository(_context);
            Testes = new TesteRepository(_context);
        }

        public ITesteDetalheRepository TesteDetalhes { get; private set; }
        public ITesteRepository Testes { get; private set; }



        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {
           return _context.SaveChanges();
        }
    }
}

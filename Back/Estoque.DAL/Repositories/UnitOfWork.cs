using Estoque.DAL.Context;
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
            CidadeRepository = new CidadeRepository(_context);
            EstadoRepository = new EstadoRepository(_context);
            PaisRepository = new PaisRepository(_context);
            EnderecoRepository = new EnderecoRepository(_context);
        }
        public IPessoaRepository PessoaRepository { get; private set; }
        public ICidadeRepository CidadeRepository { get; private set; }        
        public IEstadoRepository EstadoRepository { get; private set; }
        public IPaisRepository PaisRepository { get; private set; }
        public IEnderecoRepository EnderecoRepository { get; private set; }

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

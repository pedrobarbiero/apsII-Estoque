using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Comon.RepositoryPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;


        public UnitOfWork(DbContext context)
        {
            _context = context;
            PessoaRepository = new PessoaRepository(_context);
            CidadeRepository = new CidadeRepository(_context);
            EstadoRepository = new EstadoRepository(_context);
            PaisRepository = new PaisRepository(_context);
            EnderecoRepository = new EnderecoRepository(_context);
            TelefoneRepository = new TelefoneRepository(_context);
            PessoaFisicaRepository = new PessoaFisicaRepository(_context);
            PessoaJuridicaRepository = new PessoaJuridicaRepository(_context);
            
        }
        public IPessoaRepository PessoaRepository { get; private set; }
        public ICidadeRepository CidadeRepository { get; private set; }         
        public IEstadoRepository EstadoRepository { get; private set; }
        public IPaisRepository PaisRepository { get; private set; }
        public IEnderecoRepository EnderecoRepository { get; private set; }
        public ITelefoneRepository TelefoneRepository { get; private set; }
        public IPessoaFisicaRepository PessoaFisicaRepository { get; private set; }
        public IPessoaJuridicaRepository PessoaJuridicaRepository { get; private set; }

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

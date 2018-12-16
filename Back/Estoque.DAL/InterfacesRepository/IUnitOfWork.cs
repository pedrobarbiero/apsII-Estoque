using System;
using System.Threading.Tasks;

namespace Estoque.DAL.InterfacesRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IPessoaRepository PessoaRepository { get; }
        ICidadeRepository CidadeRepository { get; }
        IEstadoRepository EstadoRepository { get; }
        IPaisRepository PaisRepository { get; }
        IEnderecoRepository EnderecoRepository { get; }
        ITelefoneRepository TelefoneRepository { get; }
        IPessoaFisicaRepository PessoaFisicaRepository { get; }
        IPessoaJuridicaRepository PessoaJuridicaRepository { get; }
        int SaveChanges();

        Task<int> SaveChangesAsync();        
    }
}

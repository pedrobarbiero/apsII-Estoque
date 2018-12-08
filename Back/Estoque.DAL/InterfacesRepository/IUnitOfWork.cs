using Estoque.DAL.Entities;
using System;
using System.Threading.Tasks;

namespace Estoque.DAL.InterfacesRepository
{
    public interface IUnitOfWork : IDisposable
    {        
        IPessoaRepository PessoaRepository { get; }
        int SaveChanges();

        Task<int> SaveChangesAsync();        
    }
}

using Estoque.DAL.Entities;
using System;

namespace Estoque.DAL.InterfacesRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ITesteDetalheRepository TesteDetalhes { get; }
        ITesteRepository Testes { get; }

        int SaveChanges();
    }
}

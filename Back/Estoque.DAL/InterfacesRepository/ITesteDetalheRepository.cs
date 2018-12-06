using Estoque.DAL.Entities;

namespace Estoque.DAL.InterfacesRepository
{
    public interface ITesteDetalheRepository: IRepository<TesteDetalhe>
    {
        string Detalhe();
    }
}

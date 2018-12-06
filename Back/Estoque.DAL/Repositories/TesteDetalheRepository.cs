using Estoque.DAL.Context;
using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;

namespace Estoque.DAL.Repositories
{
    public class TesteDetalheRepository : Repository<TesteDetalhe>, ITesteDetalheRepository
    {
        public TesteDetalheRepository(TesteContext context) : base(context)
        {
        }

        public string Detalhe()
        {
            return "detalhe teste";
        }
    }
}

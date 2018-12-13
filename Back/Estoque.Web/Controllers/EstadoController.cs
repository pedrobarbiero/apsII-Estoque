using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;

namespace Estoque.Web.Controllers
{
    public class EstadoController : CrudController<EstadoRepository, Estado>
    {
        public EstadoController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = _uow.EstadoRepository;
        }
    }
}
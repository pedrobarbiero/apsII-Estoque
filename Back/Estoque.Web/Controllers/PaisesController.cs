using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;
using Estoque.Entities;

namespace Estoque.Web.Controllers
{
    public class PaisesController : CrudController<PaisRepository, Pais>
    {
        public PaisesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = _uow.PaisRepository;
        }        
    }
}

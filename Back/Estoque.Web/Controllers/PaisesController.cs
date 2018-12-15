using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;

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

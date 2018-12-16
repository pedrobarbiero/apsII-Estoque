using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;

namespace Estoque.Web.Controllers
{
    public class CidadesController : CrudController<CidadeRepository, Cidade>
    {
        public CidadesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = _uow.CidadeRepository;
        }
        protected override void LoadDropdown(Cidade entity)
        {
            ViewBag.EstadoId = _uow.EstadoRepository.CreateSelectList(entity.EstadoId);             
        }

    
    }
}

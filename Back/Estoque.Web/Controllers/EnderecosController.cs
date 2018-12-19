using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;
using Estoque.Entities;

namespace Estoque.Web.Controllers
{
    public class EnderecosController : CrudController<EnderecoRepository, Endereco>
    {
        public EnderecosController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = unitOfWork.EnderecoRepository;
        }
        protected override void LoadDropdown(Endereco entity)
        {
            ViewBag.CidadeId = _uow.CidadeRepository.CreateSelectList(entity.CidadeId);            
        }
    }
}

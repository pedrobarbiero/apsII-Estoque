using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;
using Estoque.Entities;

namespace Estoque.Web.Controllers
{
    public class PessoasFisicasController : CrudController<PessoaFisicaRepository, PessoaFisica>
    {
        public PessoasFisicasController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = unitOfWork.PessoaFisicaRepository;
        }
        protected override void LoadDropdown(PessoaFisica entity)
        {
            ViewBag.PessoaId = _uow.PessoaRepository.CreateSelectList(entity.PessoaId);
        }
    }
}

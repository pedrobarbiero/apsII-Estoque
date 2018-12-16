using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;

namespace Estoque.Web.Controllers
{
    public class PessoasJuridicasController : CrudController<PessoaJuridicaRepository, PessoaJuridica>
    {
        public PessoasJuridicasController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = unitOfWork.PessoaJuridicaRepository;
        }
        protected override void LoadDropdown(PessoaJuridica entity)
        {
            ViewBag.PessoaId = _uow.PessoaRepository.CreateSelectList(entity.PessoaId);
        }
    }
}

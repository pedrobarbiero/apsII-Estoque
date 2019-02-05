using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;
using Estoque.Entities;

namespace Estoque.Web.Controllers
{
    public class PessoasController : CrudController<PessoaRepository, Pessoa>
    {
        public PessoasController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = _uow.PessoaRepository;
        }
        protected override void LoadDropdown(Pessoa entity)
        {
            ViewBag.EnderecoId = _uow.EnderecoRepository.CreateSelectList(entity.EnderecoId);
        }

    }
}

using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;

namespace Estoque.Web.Controllers
{
    public class PessoasController : CrudController<PessoaRepository, Pessoa>
    {
        public PessoasController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = _uow.PessoaRepository;
        }
    }
}

using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;

namespace Estoque.Web.Controllers
{
    public class TelefonesController : CrudController<TelefoneRepository, Telefone>
    {
        public TelefonesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = unitOfWork.TelefoneRepository;
        }
    }
}

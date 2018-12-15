using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

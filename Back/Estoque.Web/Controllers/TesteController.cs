using Estoque.DAL.InterfacesRepository;
using Microsoft.AspNetCore.Mvc;

namespace Estoque.Web.Controllers
{
    public class TesteController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TesteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var testes = _unitOfWork.Testes.Get();
            return View(testes);
        }
    }
}
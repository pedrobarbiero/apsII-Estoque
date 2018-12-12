using Microsoft.AspNetCore.Mvc;

namespace Estoque.Web.Controllers
{
    public class CidadesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
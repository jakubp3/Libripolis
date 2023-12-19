using Microsoft.AspNetCore.Mvc;

namespace Libripolis.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

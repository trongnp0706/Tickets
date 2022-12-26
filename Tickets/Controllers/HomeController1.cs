using Microsoft.AspNetCore.Mvc;

namespace Tickets.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

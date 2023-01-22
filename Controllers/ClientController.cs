using Microsoft.AspNetCore.Mvc;

namespace MVC.In.Class.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

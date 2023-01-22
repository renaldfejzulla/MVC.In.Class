using Microsoft.AspNetCore.Mvc;

namespace MVC.In.Class.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

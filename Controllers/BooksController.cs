using Microsoft.AspNetCore.Mvc;

namespace MVC.In.Class.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

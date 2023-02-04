using Microsoft.AspNetCore.Mvc;
using MVC.In.Class.Services.IServices;

namespace MVC.In.Class.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService authorService;

        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        public async Task<IActionResult> Index()
        {
            var resultTotal = await authorService.GetAll();

            return View(resultTotal);
        }
        //public IActionResult Create()
        //{
        //    var resultTotal = authorService.GetAll();

        //    return View(resultTotal);
        //}
    }
}

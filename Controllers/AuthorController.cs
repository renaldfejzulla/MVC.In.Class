using Microsoft.AspNetCore.Mvc;
using MVC.In.Class.DataAcessLayer.Entities;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Author author)
        {
            if (ModelState.IsValid)
            {
                var resultTotal = await authorService.CreateAuthor(author);
            }
           

            return View();
        }
        // GET: Authors/Create
        public IActionResult Create()
        {
            return View("Create");
        }
    }
}

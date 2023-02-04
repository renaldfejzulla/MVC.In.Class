using Microsoft.AspNetCore.Mvc;
using MVC.In.Class.Services;

namespace MVC.In.Class.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService ?? throw new ArgumentNullException(nameof(authorService));
        }

        public async Task<IActionResult> Index()
        {
            var resultTotal = await _authorService.GetAuthorAsync();
            return View(resultTotal);
        }

    }
}

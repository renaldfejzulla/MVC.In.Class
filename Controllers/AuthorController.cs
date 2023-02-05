using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.Models;
using MVC.In.Class.Services;

namespace MVC.In.Class.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService ?? throw new ArgumentNullException(nameof(authorService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
        }

        public async Task<IActionResult> Index()
        {
            var resultTotal = await _authorService.GetAuthorAsync();
            return View(resultTotal);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AuthorViewModel author)
        {
            var mappedUser = _mapper.Map<Author>(author);
            if (ModelState.IsValid)
            {
                var resultTotal = await _authorService.Create(mappedUser);
            }

            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var author = await _authorService.GetAuthorById(id);

            if (author==null)
            {
                return NotFound();
            }

            return View(author);
        }


    }
}

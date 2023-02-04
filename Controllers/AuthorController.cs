using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.Models;
using MVC.In.Class.Services.IServices;

namespace MVC.In.Class.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService authorService;
        // define the mapper
        private readonly IMapper _mapper;
        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            this.authorService = authorService;
            _mapper = mapper;  
        }

        public async Task<IActionResult> Index()
        {
            var resultTotal = await authorService.GetAll();

            return View(resultTotal);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AuthorViewModel authorview)
        {

            // utilise the mapping 
             var _mappedUser = _mapper.Map<Author>(authorview);
            if (ModelState.IsValid)
            {
                var resultTotal = await authorService.CreateAuthor(_mappedUser);
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

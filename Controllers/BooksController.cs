using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVC.In.Class.Models;
using MVC.In.Class.Services.IServices;

namespace MVC.In.Class.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksService booksService;
        private readonly IMapper _mapper;

        public BooksController(IBooksService booksService, IMapper mapper)
        {
            this.booksService = booksService;
            _mapper = mapper;
        }

        public async Task< IActionResult> Index()
        {

            var result = await booksService.GetAll();
            var mappedBook = _mapper.Map<IEnumerable<BookViewModel>>(result);
            return View(mappedBook);
        }
    }
}

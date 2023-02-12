using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVC.In.Class.DataAcessLayer.Repository.Interface;
using MVC.In.Class.Models;
using MVC.In.Class.Services;

namespace MVC.In.Class.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookservice;
        private readonly IMapper _mapper;

        public BookController(IBookService bookService, IMapper mapper)
        {
            _bookservice = bookService ?? throw new ArgumentNullException(nameof(bookService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IActionResult> Index()
        {
            var result = await _bookservice.GetBooksAsync();
            var mappedBook = _mapper.Map<IEnumerable<BookViewModel>>(result);

            if (mappedBook == null)
            {
                return NotFound();
            }

            return View(mappedBook);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MVC.In.Class.DataAcessLayer.Repository.Interface;

namespace MVC.In.Class.Controllers
{
    public class BooksController : Controller
    {
        IBookRepository bookRepository;
        public BooksController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

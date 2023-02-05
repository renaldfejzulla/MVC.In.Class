using MVC.In.Class.DataAcessLayer.DTO;
using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.DataAcessLayer.Repository.Interface;

namespace MVC.In.Class.Services
{
    public class BookService : IBookService
    {   
        private IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository= bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
        }
        public async Task<IEnumerable<BookDTO>> GetBooksAsync()
        {
            var result = await _bookRepository.GetAllBooks();
            return result;
        }
    }
}

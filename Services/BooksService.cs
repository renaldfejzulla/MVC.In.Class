using MVC.In.Class.Models;
using MVC.In.Class.repository;
using MVC.In.Class.Services.IServices;

namespace MVC.In.Class.Services
{
    public class BooksService: IBooksService
    {
        private readonly IBooksRepository BooksRepository;

        public BooksService(IBooksRepository booksRepository)
        {
            BooksRepository = booksRepository;
        }

        public async Task<IEnumerable<BooksDto>> GetAll()
        {
            return await BooksRepository.GetAllBooks();
        }
    }
}

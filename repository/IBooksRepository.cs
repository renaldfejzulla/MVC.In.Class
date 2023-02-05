using MVC.In.Class.Models;

namespace MVC.In.Class.repository
{
    public interface IBooksRepository
    {
        Task<IEnumerable<BooksDto>> GetAllBooks();
    }
}

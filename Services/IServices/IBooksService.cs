using MVC.In.Class.Models;

namespace MVC.In.Class.Services.IServices
{
    public interface IBooksService
    {
        Task<IEnumerable<BooksDto>> GetAll();
    }
}

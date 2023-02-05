using MVC.In.Class.DataAcessLayer.DTO;
using MVC.In.Class.DataAcessLayer.Entities;

namespace MVC.In.Class.Services
{
    public interface IBookService
    {
         Task<IEnumerable<BookDTO>> GetBooksAsync();
    }
}

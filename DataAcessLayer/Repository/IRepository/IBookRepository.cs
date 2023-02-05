using MVC.In.Class.DataAcessLayer.DTO;
using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.DataAcessLayer.Repository.Generic;

namespace MVC.In.Class.DataAcessLayer.Repository.Interface
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookDTO>> GetAllBooks();
        Task<Book> GetBookById(Guid id);
        Task<Book> GetBookByName(string name);
        Task<Book> AddAsyncBook(Book book);
        Task<Book> UpdateAsyncBook(string title, double Price);
        Task<bool> DeleteAsyncBook(string name);
    }
}

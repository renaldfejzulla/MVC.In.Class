using Microsoft.EntityFrameworkCore;
using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.Models;

namespace MVC.In.Class.repository
{
    public class BooksRepository: IBooksRepository
    {
        private readonly LibraryDBContext _context;

        public BooksRepository(LibraryDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BooksDto>> GetAllBooks()
        {
            var result = await (from book in _context.Books
                          join AuthBook in _context.AuthorBooks
                          on book.Id equals AuthBook.BookId into left
                          from a in left.DefaultIfEmpty()
                          select new BooksDto
                          {
                              Id = book.Id,
                              Title = book.Title,
                              Price = book.Price,
                              PublishedYear = book.PublishedYear,

                          }).ToListAsync();

            return result;
        }
    }
}

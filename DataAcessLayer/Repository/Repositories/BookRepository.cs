using Microsoft.EntityFrameworkCore;
using MVC.In.Class.DataAcessLayer.Context;
using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.DataAcessLayer.Repository.Interface;

namespace MVC.In.Class.DataAcessLayer.Repository.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDBContext _context;
        public BookRepository(LibraryDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); ;
        }
        public async Task<Book> AddAsyncBook(Book book)
        {
            var result = await _context.Books.AddAsync(book);
            _context.SaveChanges();
            return result.Entity;
        }

        public async Task<bool> DeleteAsyncBook(string name)
        {
            Book result = await GetBookByName(name);
            result.IsDeleted = true;
            result.DateUpdated = DateTime.Now;
            _context.Update(result);
            _context.SaveChanges();
            return true;

        }

        public async Task<List<Book>> GetAllBooks()
        {
            var result = await _context.Books.Where(x=> x.IsDeleted==false).ToListAsync();
            return result;
        }

        public async Task<Book> GetBookById(Guid id)
        {
            var result = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<Book> GetBookByName(string name)
        {
            var result = await _context.Books.FirstOrDefaultAsync(x => x.Title == name);
            return result;
        }
        public async Task<Book> UpdateAsyncBook(string title, double Price)
        {
            Book result = await GetBookByName(title);
            result.Price= Price;
            result.DateUpdated=DateTime.Now;
            _context.Update(result);
            _context.SaveChanges();
            return result;

        }
    }
}

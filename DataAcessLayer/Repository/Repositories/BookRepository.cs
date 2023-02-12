using Microsoft.EntityFrameworkCore;
using MVC.In.Class.DataAcessLayer.Context;
using MVC.In.Class.DataAcessLayer.DTO;
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

        public async Task<IEnumerable<BookDTO>> GetAllBooks()
        {
            //var result = await _context.Books.Where(x=> x.IsDeleted==false).ToListAsync();

            var test = _context.Books
                .Include(a => a.UserLogin)
                .Include(b => b.AuthorBooks)
                .Where(a => a.IsDeleted == false).Select(a => new BookDTO
                {
                    Id = a.Id,
                    Title = a.Title,
                    Price = a.Price,
                    PublishedYear = a.PublishedYear,
                    Roles = a.UserLogin.Roles
                });



            //left join using linQ in C#
            var result = await (from book in _context.Books
                                join authorBook in _context.AuthorBooks
                                on book.Id equals authorBook.BookId into left
                                from a in left.DefaultIfEmpty()
                                join Users in _context.UserLogins
                                on book.UserLoginId equals Users.Id
                                where book.IsDeleted ==false
                                select new BookDTO
                                {
                                    Id = book.Id,
                                    Title = book.Title,
                                    Price = book.Price,
                                    PublishedYear = book.PublishedYear,
                                    Roles = Users.Roles
                                }).ToListAsync();
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
            result.Price = Price;
            result.DateUpdated = DateTime.Now;
            _context.Update(result);
            _context.SaveChanges();
            return result;

        }
    }
}

using Microsoft.EntityFrameworkCore;
using MVC.In.Class.DataAcessLayer.Context;
using MVC.In.Class.DataAcessLayer.DTO;
using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.DataAcessLayer.Repository.IRepository;

namespace MVC.In.Class.DataAcessLayer.Repository.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        LibraryDBContext _context;
        public AuthorRepository(LibraryDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Author> CreateAsync(Author author)
        {
            var result = await _context.Authors.AddAsync(author);
            _context.SaveChanges();
            return result.Entity;
        }

        public async Task<IEnumerable<Author>> GetAll(string search)
        {
            var result = await _context.Authors.Where(a => a.IsDeleted == false).ToListAsync();
            if (!string.IsNullOrEmpty(search))
            {
                result = await _context.Authors.Where(a => a.IsDeleted == false && a.Name.Contains(search)).ToListAsync();
            }

            return result;
        }

        public async Task<AuthorDTO> GetAuthorAsync(Guid? id)
        {
            var res = await (from Author in _context.Authors
                             join AuthorBook in _context.AuthorBooks on Author.Id
                             equals AuthorBook.AuthorId
                             join Book in _context.Books
                             on AuthorBook.BookId equals Book.Id
                             where Author.Id == id
                             select new AuthorDTO
                             {
                                 Name = Author.Name,
                                 BirthYear = Author.BirthYear,
                                 Title = Book.Title,
                                 Price = Book.Price
                             }).FirstOrDefaultAsync();
            return res;
        }
    }
}

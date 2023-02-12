using Microsoft.EntityFrameworkCore;
using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.Models;

namespace MVC.In.Class.repository
{
    public class AuthorRepository:IAuthorRepository
    {
        private readonly LibraryDBContext _context;

        public AuthorRepository(LibraryDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Author>> GetAllAuthor(string searchString)
        {      
            var result = await _context.Authors.Where(author => author.IsDeleted == false).ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                result = await _context.Authors.Where(author => author.IsDeleted == false &&author.Name.Contains(searchString)).ToListAsync();
            }
            
            return result;
        }
        public async Task<Author> CreateAuthor(Author author)
        {
             await  _context.Authors.AddAsync(author);
            _context.SaveChangesAsync();

            return author;
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

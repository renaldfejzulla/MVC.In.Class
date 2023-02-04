using Microsoft.EntityFrameworkCore;
using MVC.In.Class.DataAcessLayer.Entities;

namespace MVC.In.Class.repository
{
    public class AuthorRepository:IAuthorRepository
    {
        private readonly LibraryDBContext _context;

        public AuthorRepository(LibraryDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Author>> GetAllAuthor()
        {
            return await _context.Authors.Where(author => author.IsDeleted == false).ToListAsync();
        }
        public async Task<Author> CreateAuthor(Author author)
        {
             await  _context.Authors.AddAsync(author);
            _context.SaveChangesAsync();

            return author;
        }
    }
}

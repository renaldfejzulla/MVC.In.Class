using Microsoft.EntityFrameworkCore;
using MVC.In.Class.DataAcessLayer.Context;
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

        public async Task<IEnumerable<Author>> GetAll()
        {
            var result = await _context.Authors.ToListAsync();
            return result;
        }
    }
}

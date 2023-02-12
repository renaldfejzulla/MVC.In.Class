using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.Models;

namespace MVC.In.Class.repository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAllAuthor(string searchString);
        Task<Author> CreateAuthor(Author author);
        Task<AuthorDTO> GetAuthorAsync(Guid? id);
    }
}

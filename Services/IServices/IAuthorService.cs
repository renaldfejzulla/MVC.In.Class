using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.Models;

namespace MVC.In.Class.Services.IServices
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAll(string searchString);
        Task<Author> CreateAuthor(Author author);
        Task<AuthorDTO> AuthorDetails(Guid? id);
    }
}

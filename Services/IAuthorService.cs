using MVC.In.Class.DataAcessLayer.DTO;
using MVC.In.Class.DataAcessLayer.Entities;

namespace MVC.In.Class.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAuthorAsync(string search);
        Task<Author> Create(Author author);
        Task<AuthorDTO> GetAuthorById(Guid? id);
    }
}

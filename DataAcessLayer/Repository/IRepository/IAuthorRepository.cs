using MVC.In.Class.DataAcessLayer.DTO;
using MVC.In.Class.DataAcessLayer.Entities;

namespace MVC.In.Class.DataAcessLayer.Repository.IRepository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAll(string search);
        Task<Author> CreateAsync(Author author);
        Task<AuthorDTO> GetAuthorAsync(Guid? id);
    }
}

using MVC.In.Class.DataAcessLayer.Entities;

namespace MVC.In.Class.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAuthorAsync();
        Task<Author> Create(Author author);
    }
}

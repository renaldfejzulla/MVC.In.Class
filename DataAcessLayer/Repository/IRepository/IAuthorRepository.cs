using MVC.In.Class.DataAcessLayer.Entities;

namespace MVC.In.Class.DataAcessLayer.Repository.IRepository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAll();
        Task<Author> CreateAsync(Author author);
    }
}

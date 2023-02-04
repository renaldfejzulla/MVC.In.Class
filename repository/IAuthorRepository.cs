using MVC.In.Class.DataAcessLayer.Entities;

namespace MVC.In.Class.repository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAllAuthor();
        Task<Author> CreateAuthor(Author author);
    }
}

using MVC.In.Class.DataAcessLayer.Entities;

namespace MVC.In.Class.Services.IServices
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAll();
    }
}

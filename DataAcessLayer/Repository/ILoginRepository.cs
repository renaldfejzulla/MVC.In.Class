using MVC.In.Class.DataAcessLayer.Entities;

namespace MVC.In.Class.DataAcessLayer.Repository
{
    public interface ILoginRepository
    {
        Task<IEnumerable<UserLogin>> GetUser();
        Task<UserLogin> AuthenticateUser(string username, string passcode);

    }
}

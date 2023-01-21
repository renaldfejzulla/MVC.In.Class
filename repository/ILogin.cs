using MVC.In.Class.DataAcessLayer.Entities;

namespace MVC.In.Class.repository
{
    public interface ILogin
    {
        Task<IEnumerable<UserLogin>> getuser();
        Task<UserLogin> AuthenticateUser(string username, string passcode);
    }
}

using Microsoft.EntityFrameworkCore;
using MVC.In.Class.DataAcessLayer.Context;
using MVC.In.Class.DataAcessLayer.Entities;

namespace MVC.In.Class.DataAcessLayer.Repository
{
    public class AuthenticatonLoginRepository : ILoginRepository
    {
        private readonly LibraryDBContext _context;
        public AuthenticatonLoginRepository(LibraryDBContext context)
        {
            _context = context;
        }

        public async Task<UserLogin> AuthenticateUser(string username, string passcode)
        {
            var success = await _context.UserLogins.FirstOrDefaultAsync(x => x.UserName == username && x.Password == passcode);
            return success;
        }

        public async Task<IEnumerable<UserLogin>> GetUser()
        {
            return await _context.UserLogins.ToListAsync();

        }
    }
}

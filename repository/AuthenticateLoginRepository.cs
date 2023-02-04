using Microsoft.EntityFrameworkCore;
using MVC.In.Class.DataAcessLayer.Context;
using MVC.In.Class.DataAcessLayer.Entities;

namespace MVC.In.Class.repository
{
    public class AuthenticateLoginRepository : ILoginRepository
    {
        private readonly LibraryDBContext _context;

        public AuthenticateLoginRepository(LibraryDBContext context)
        {
            _context = context;
        }
        public async Task<UserLogin> AuthenticateUser(string username, string passcode)
        {
            var succeeded = await _context.UserLogins.FirstOrDefaultAsync(authUser => authUser.UserName == username && authUser.Password == passcode);
            return succeeded;
        }

        public async Task<IEnumerable<UserLogin>> getuser()
        {
            return await _context.UserLogins.ToListAsync();
        }
    }
}

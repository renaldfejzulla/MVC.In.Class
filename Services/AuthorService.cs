using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.Models;
using MVC.In.Class.repository;
using MVC.In.Class.Services.IServices;

namespace MVC.In.Class.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository AuthorRepository;
        private readonly ILoginRepository LoginRepository;

        public AuthorService(IAuthorRepository authorRepository, ILoginRepository loginRepository)
        {
            AuthorRepository = authorRepository;
            LoginRepository = loginRepository;
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            return await AuthorRepository.GetAllAuthor();
        }
        public async Task<Author> CreateAuthor(Author author)
        {
            return await AuthorRepository.CreateAuthor(author);
        }
        public async Task<AuthorDTO> AuthorDetails(Guid? id)
        {
            return await AuthorRepository.GetAuthorAsync(id);
        }
    }
}

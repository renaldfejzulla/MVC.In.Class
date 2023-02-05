using MVC.In.Class.DataAcessLayer.DTO;
using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.DataAcessLayer.Repository;
using MVC.In.Class.DataAcessLayer.Repository.IRepository;

namespace MVC.In.Class.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _repository;
        private readonly ILoginRepository _loginRepository;

        public AuthorService(IAuthorRepository repository, ILoginRepository loginRepository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _loginRepository = loginRepository ?? throw new ArgumentNullException(nameof(loginRepository));
        }

        public async Task<Author> Create(Author author)
        {
            var result = await _repository.CreateAsync(author);
            return result;
        }

        public async Task<IEnumerable<Author>> GetAuthorAsync()
        {
            var result = await _repository.GetAll();
            return result;
        }

        public async Task<AuthorDTO> GetAuthorById(Guid? id)
        {
            var result = await _repository.GetAuthorAsync(id);
            return result;
        }
    }
}

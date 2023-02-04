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

        public async Task<IEnumerable<Author>> GetAuthorAsync()
        {
            var result = await _repository.GetAll();
            return result;
        }
    }
}

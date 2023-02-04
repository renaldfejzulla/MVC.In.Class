﻿using MVC.In.Class.DataAcessLayer.Entities;
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
    }
}

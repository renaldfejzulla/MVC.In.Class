using AutoMapper;
using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.Models;

namespace MVC.In.Class.MapperProfiler
{
    public class AuthorProfiler:Profile
    {
        public AuthorProfiler()
        {
            CreateMap<AuthorViewModel, Author>();
        }
    }
}

using AutoMapper;
using MVC.In.Class.DataAcessLayer.DTO;
using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.Models;

namespace MVC.In.Class.AutoMapperProfiler
{
    public class AuthorBookProfiler : Profile
    {
        public AuthorBookProfiler()
        {
            CreateMap<AuthorDTO, AuthorBookViewModel>();
        }
    }
}

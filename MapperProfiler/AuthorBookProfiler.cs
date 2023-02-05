using AutoMapper;
using MVC.In.Class.Models;

namespace MVC.In.Class.MapperProfiler
{
    public class AuthorBookProfiler:Profile
    {
        public AuthorBookProfiler()
        {
            CreateMap<AuthorDTO, AuthorBookViewModel>();
        }
    }
}

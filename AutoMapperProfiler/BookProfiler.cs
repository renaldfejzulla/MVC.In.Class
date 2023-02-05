using AutoMapper;
using MVC.In.Class.DataAcessLayer.DTO;
using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.Models;

namespace MVC.In.Class.AutoMapperProfiler
{
    public class BookProfiler : Profile
    {
        public BookProfiler()
        {
            CreateMap<BookDTO,BookViewModel>();
        }
    }
}

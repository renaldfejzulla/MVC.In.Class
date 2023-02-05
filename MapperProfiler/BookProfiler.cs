using AutoMapper;
using MVC.In.Class.Models;

namespace MVC.In.Class.MapperProfiler
{
    public class BookProfiler:Profile
    {
        public BookProfiler()
        {
            CreateMap<BooksDto, BookViewModel>();
        }
    }
}

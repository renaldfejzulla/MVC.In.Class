using Microsoft.EntityFrameworkCore;
using MVC.In.Class.DataAcessLayer.Context;
using MVC.In.Class.DataAcessLayer.Repository;
using MVC.In.Class.DataAcessLayer.Repository;
using MVC.In.Class.DataAcessLayer.Repository.Interface;
using MVC.In.Class.DataAcessLayer.Repository.IRepository;
using MVC.In.Class.DataAcessLayer.Repository.Repositories;
using MVC.In.Class.Services;
using System.Text.Json.Serialization;

namespace MVC.In.Class
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddJsonOptions(options =>
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            // add database dependecy
            _ = builder.Services.AddDbContext<LibraryDBContext>(c =>
            {
                c.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                c.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            });
            //add dipendency automapper
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //inject classes into program
            builder.Services.AddScoped<ILoginRepository, AuthenticatonLoginRepository>();
            builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
            builder.Services.AddScoped<IAuthorService, AuthorService>();
            builder.Services.AddScoped<IBookRepository, BookRepository>();
      
       var app = builder.Build();
           
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Login}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
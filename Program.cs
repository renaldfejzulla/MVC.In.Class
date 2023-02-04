using Microsoft.EntityFrameworkCore;
using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.repository;
using MVC.In.Class.Services;
using MVC.In.Class.Services.IServices;
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
                c.UseSqlServer(builder.Configuration.GetConnectionString("Library"));
                c.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            });
            //inject automapper
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //inject classes into program           
            builder.Services.AddScoped<ILoginRepository, AuthenticateLoginRepository>();
            builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
            builder.Services.AddScoped<IAuthorService, AuthorService>();
      
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
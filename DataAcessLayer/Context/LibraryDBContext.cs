using Microsoft.EntityFrameworkCore;
using MVC.In.Class.DataAcessLayer.Entities;
using MVC.In.Class.Models;

namespace MVC.In.Class.DataAcessLayer.Context
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext()
        {

        }

        public LibraryDBContext(DbContextOptions<LibraryDBContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<AuthorBook> AuthorBooks { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<BookRentals> BookRentals { get; set; } = null!;
        public virtual DbSet<UserLogin> UserLogins { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }


        public DbSet<MVC.In.Class.Models.BooksDto> BooksDto { get; set; }


    }
}

using Microsoft.EntityFrameworkCore;

namespace MVC.In.Class.DataAcessLayer.Entities
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            var user = new UserLogin
            {
                Id = Guid.NewGuid(),
                UserName = "edi",
                Password = "123",
                Roles = "admin"
            };

            _ = modelBuilder.Entity<UserLogin>().HasData(user
            );
            var author = new Author
            {
                Id = Guid.NewGuid(),
                Name = "JJR Tolkien",
                BirthYear = new DateTime(1913, 2, 2),
               
            };

            _ = modelBuilder.Entity<Author>().HasData(author);

            var book = new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Hobbit",
                Price = 1500,
                PublishedYear = new DateTime(1980, 2, 2),
              

            };
            modelBuilder.Entity<Book>().HasData(book
            );
            modelBuilder.Entity<AuthorBook>().HasData(
            new AuthorBook
            {
                Id = Guid.NewGuid(),
                BookId = book.Id,
                AuthorId = author.Id,
            });
        }
    }
}

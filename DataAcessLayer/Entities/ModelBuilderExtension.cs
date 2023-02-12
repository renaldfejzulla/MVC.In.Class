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
                UserName = "user",
                Password = "1234",
                Roles = "admin"
            };

            var author = new Author
            {
                Id = Guid.NewGuid(),
                Name = "JJR Tolkien",
                BirthYear = new DateTime(1913, 2, 2)
            };

            _ = modelBuilder.Entity<Author>().HasData(author);

            var book = new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Hobbit",
                Price = 1500,
                PublishedYear = new DateTime(1980, 2, 2),
                UserLoginId = user.Id
            };
            var book1 = new Book
            {
                Id = Guid.NewGuid(),
                Title = "Kronik ne Gur",
                Price = 1500,
                PublishedYear = new DateTime(1980, 2, 2),
                UserLoginId = user.Id

            };
            var book2 = new Book
            {
                Id = Guid.NewGuid(),
                Title = "Harry Potter",
                Price = 1500,
                PublishedYear = new DateTime(1980, 2, 2),
                UserLoginId = user.Id
            };


            _ = modelBuilder.Entity<Book>().HasData(book, book1, book2);

            _ = modelBuilder.Entity<AuthorBook>().HasData(
            new AuthorBook
            {
                Id = Guid.NewGuid(),
                BookId = book.Id,
                AuthorId = author.Id,
            });
            _ = modelBuilder.Entity<UserLogin>().HasData(user);
        }
    }
}

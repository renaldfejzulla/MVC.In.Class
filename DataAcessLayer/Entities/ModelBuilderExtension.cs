using Microsoft.EntityFrameworkCore;

namespace MVC.In.Class.DataAcessLayer.Entities
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
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
            };
            _ = modelBuilder.Entity<Book>().HasData(book);

            _ = modelBuilder.Entity<AuthorBook>().HasData(
            new AuthorBook
            {
                Id = Guid.NewGuid(),
                BookId = book.Id,
                AuthorId = author.Id,
            });
        }
    }
}

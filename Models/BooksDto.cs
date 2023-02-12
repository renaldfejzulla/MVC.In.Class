namespace MVC.In.Class.Models
{
    public class BooksDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public DateTime PublishedYear { get; set; }
        public string Roles { get; set; }
    }
}

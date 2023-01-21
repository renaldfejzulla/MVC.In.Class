namespace MVC.In.Class.DataAcessLayer.Entities
{
    public class AuthorBook : BaseEntity
    {
        public Guid BookId { get; set; }
        public Guid AuthorId { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }

    }
}

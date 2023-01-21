namespace MVC.In.Class.DataAcessLayer.Entities
{
    public class Author : BaseEntity
    {
        public Author()
        {
            AuthorBooks = new HashSet<AuthorBook>();
        }
        public string Name { get; set; }
        public DateTime BirthYear { get; set; }
        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }

    }
}

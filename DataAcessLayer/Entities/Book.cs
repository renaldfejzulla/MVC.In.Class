using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.In.Class.DataAcessLayer.Entities
{
    public class Book:BaseEntity
    {
        public Book()
        {
            AuthorBooks = new HashSet<AuthorBook>();
        }
        public string Title { get; set; }
        public double Price { get; set; }
        public DateTime PublishedYear { get; set; }
        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }

        [ForeignKey(nameof(UserLoginId))]

        public Guid UserLoginId { get;set; }
        public UserLogin UserLogin { get; set; }

    }
}

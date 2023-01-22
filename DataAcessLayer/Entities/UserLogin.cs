using System.ComponentModel.DataAnnotations;

namespace MVC.In.Class.DataAcessLayer.Entities
{
    public class UserLogin : BaseEntity
    {
        [Required(ErrorMessage = "Please Enter Username")]
        [Display(Name = "Please Enter Username")]
        public string UserName { get; set; }
       
        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Please Enter Password")]
        public string Password { get; set; }
        public string Roles { get; set; }

    }
}

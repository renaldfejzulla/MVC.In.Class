using Microsoft.AspNetCore.Mvc;
using MVC.In.Class.DataAcessLayer.Repository;

namespace MVC.In.Class.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ILoginRepository _login;
        public LoginController(ILogger<LoginController> logger, ILoginRepository login)
        {
            _logger = logger;
            _login = login;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var issuccess = _login.AuthenticateUser(username, password);

            if (issuccess.Result != null)
            {
                _logger.LogInformation("Log this message in the Index() method");
                return RedirectToAction("Index", "Home");
            }

            else
            {
                ViewBag.username = string.Format("Login Failed", username);
                return View();

            }
        }
    }
}

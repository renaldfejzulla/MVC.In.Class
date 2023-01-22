using Microsoft.AspNetCore.Mvc;
using MVC.In.Class.Models;
using MVC.In.Class.repository;
using System.Diagnostics;

namespace MVC.In.Class.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ILoginRepository _loginUser;
        public LoginController(ILogger<LoginController> logger, ILoginRepository loginUser)
        {
            _logger = logger;
            _loginUser = loginUser;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string username,string Password)
        {
            var issuccess = _loginUser.AuthenticateUser(username, Password);
 
 
            if (issuccess.Result != null)
            {
                //ViewBag.username = string.Format("Successfully logged-in", username);
                //RedirectToAction (string actionName, string controllerName);
                //return View();  
                return RedirectToAction("Index", "Home");
            }
            else {
                ViewBag.username = string.Format("Login Failed ", username);
                return View();
            }            
        }

       
    }
}
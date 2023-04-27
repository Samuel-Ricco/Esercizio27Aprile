using Esercizio27Aprile.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Esercizio27Aprile.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //testing purpose------------------------------
        private User user1 = new User("test1","password1");
        private User user2 = new User("test2", "password2");
        private User user3 = new User("test3", "password3");

        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            UserList.AddUser(user1);
            UserList.AddUser(user2);
            UserList.AddUser(user3);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult UserView()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult MetodoProva() 
        {
            var myMail = Request.Form["mail"].ToString();
            var myPassword = Request.Form["password"].ToString();

            if (UserModel.LogIn(myMail, myPassword)) 
            {
                return RedirectToAction("UserView");
            }
            return RedirectToAction("Index");

        }
    }
}
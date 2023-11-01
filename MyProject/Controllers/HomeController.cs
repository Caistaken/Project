using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using System.Diagnostics;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        public class AccountData
        {
            public string NickName { get; set; }
            public string Password { get; set; }


        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult blog()
        {

            return View();
        }

        public IActionResult blog2()
        {

            return View();
        }

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult account(AccountData model)
        {

            return View("Index");
        }
    }
}
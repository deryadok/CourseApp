using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            int saat = DateTime.Now.Hour;

            ViewBag.Greeting = saat > 12 ? "İyi günler": "Günaydın";
            ViewBag.UserName = "Derya";
            return View();
        }

        public IActionResult About(){
            return View();
        }
    }
}
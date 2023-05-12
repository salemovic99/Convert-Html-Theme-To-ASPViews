using ConvvertHtmlThemeToAspViews.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConvvertHtmlThemeToAspViews.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult About()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Singl()
        {
            return View();
        }

    }
}
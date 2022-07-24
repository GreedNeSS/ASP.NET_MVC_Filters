using Microsoft.AspNetCore.Mvc;
using _1_Introduction.Filters;
using System;

namespace _1_Introduction.Controllers
{
    public class HomeController : Controller
    {
        [SimpleResourceFilter]
        public IActionResult Index()
        {
            return View();
        }

        [FakeNotFoundResourceFilter]
        public IActionResult Private()
        {
            return Content("Private Page");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using _5_ActionFilter.Filters;
using System;

namespace _5_ActionFilter.Controllers
{
    public class HomeController : Controller
    {
        [Whitespace]
        public IActionResult Index()
        {
            return View();
        }

        [CheckFilter]
        public IActionResult Info(int id)
        {
            return Content($"Id: {id}");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using _6_ResultFilter.Filters;
using System;

namespace _6_ResultFilter.Controllers
{
    public class HomeController : Controller
    {
        [DateResultFilter]
        public IActionResult Index()
        {
            return Content("Main Page");
        }

        [CanceledResultFilter]
        public IActionResult Info()
        {
            return Content("Info Page");
        }
    }
}

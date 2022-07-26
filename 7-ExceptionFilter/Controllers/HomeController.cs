using Microsoft.AspNetCore.Mvc;
using _7_ExceptionFilter.Filters;

namespace _7_ExceptionFilter.Controllers
{
    public class HomeController : Controller
    {
        [CustomExceptionFilter]
        public IActionResult Index()
        {
            int x = 0;
            int y = 8 / x;
            return Content($"Result: {y}");
        }
    }
}

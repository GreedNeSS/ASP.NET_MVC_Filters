using Microsoft.AspNetCore.Mvc;
using _2_ScopeOfFilters.Filters;

namespace _2_ScopeOfFilters.Controllers
{
    [ControllerResourceFilter(int.MinValue)]
    public class HomeController : Controller
    {
        [ActionResourceFilter]
        public IActionResult Index()
        {
            return View();
        }
    }
}

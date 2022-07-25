using Microsoft.AspNetCore.Mvc;
using _4_ResourceFilter.Filters;

namespace _4_ResourceFilter.Controllers
{
    public class HomeController : Controller
    {
        [IEAsyncFilter]
        public IActionResult Index()
        {
            return Content("Main Page");
        }
    }
}

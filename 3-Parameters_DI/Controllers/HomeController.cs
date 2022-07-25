using Microsoft.AspNetCore.Mvc;
using _3_Parameters_DI.Filters;

namespace _3_Parameters_DI.Controllers
{
    public class HomeController : Controller
    {
        [TypeFilter(typeof(LogResourceFilter))]
        [TokenResourceFilter(234, "vrvhjw32-cvw32-2f23d-f23rf2dw")]
        public IActionResult Index()
        {
            return Content("Main Page");
        }
        
        [ServiceFilter(typeof(LogResourceFilter))]
        public IActionResult Info()
        {
            return Content("Info Page");
        }
    }
}

using Microsoft.AspNetCore.Mvc.Filters;

namespace _1_Introduction.Filters
{
    public class SimpleResourceFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            context.HttpContext.Response.Cookies.Append("LastVisit", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
        }
    }
}

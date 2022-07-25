using Microsoft.AspNetCore.Mvc.Filters;

namespace _5_ActionFilter.Filters
{
    public class CheckFilterAttribute : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            context.ActionArguments["id"] = 31;
            await next();
        }
    }
}

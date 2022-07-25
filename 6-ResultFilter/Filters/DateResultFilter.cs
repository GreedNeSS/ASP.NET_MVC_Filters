using Microsoft.AspNetCore.Mvc.Filters;

namespace _6_ResultFilter.Filters
{
    public class DateResultFilter : Attribute, IAsyncResultFilter
    {
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            context.HttpContext.Response.Headers["Date-Time"] = DateTime.Now.ToString();
            await next();
        }
    }
}

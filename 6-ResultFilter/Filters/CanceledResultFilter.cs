using Microsoft.AspNetCore.Mvc.Filters;

namespace _6_ResultFilter.Filters
{
    public class CanceledResultFilter : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {

        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.Cancel = true;
        }
    }
}

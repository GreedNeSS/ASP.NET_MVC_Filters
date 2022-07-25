using Microsoft.AspNetCore.Mvc.Filters;

namespace _2_ScopeOfFilters.Filters
{
    public class ActionResourceFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine("ActionResourceFilter.OnResourceExecuted");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine("ActionResourceFilter.OnResourceExecuting");
        }
    }
}

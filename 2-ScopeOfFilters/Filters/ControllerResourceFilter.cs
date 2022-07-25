using Microsoft.AspNetCore.Mvc.Filters;

namespace _2_ScopeOfFilters.Filters
{
    public class ControllerResourceFilter : Attribute, IResourceFilter, IOrderedFilter
    {
        public int Order { get; }

        public ControllerResourceFilter(int order) => Order = order;

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine("ControllerResourceFilter.OnResourceExecuted");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine("ControllerResourceFilter.OnResourceExecuting");
        }
    }
}

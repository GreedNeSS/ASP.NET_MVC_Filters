using Microsoft.AspNetCore.Mvc.Filters;

namespace _3_Parameters_DI.Filters
{
    public class LogResourceFilter : Attribute, IResourceFilter
    {
        ILogger _logger;

        public LogResourceFilter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<LogResourceFilter>();
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            _logger.LogInformation($"OnResourceExecuted: {DateTime.Now}\nPath: {context.HttpContext.Request.Path}");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            _logger.LogInformation($"OnResourceExecuting: {DateTime.Now}\nPath: {context.HttpContext.Request.Path}");
        }
    }
}

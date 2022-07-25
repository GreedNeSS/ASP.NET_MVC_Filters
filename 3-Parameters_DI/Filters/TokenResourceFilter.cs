using Microsoft.AspNetCore.Mvc.Filters;

namespace _3_Parameters_DI.Filters
{
    public class TokenResourceFilter : Attribute, IResourceFilter
    {
        int _id;
        string _token;

        public TokenResourceFilter(int id, string token)
        {
            _id = id;
            _token = token;
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("Id", _id.ToString());
            context.HttpContext.Response.Headers.Add("Token", _token);
        }
    }
}

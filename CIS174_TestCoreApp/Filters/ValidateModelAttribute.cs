using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace CIS174_TestCoreApp.Filters
{
    public class ValidateModelAttribute : ActionFilterAttribute 
    {
        protected ILogger logger;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                logger.LogWarning("The model state in this context is not valid {context}", context.HttpContext.Response.StatusCode);
                context.Result = new BadRequestObjectResult(context.ModelState);
            }

        }
    }
}

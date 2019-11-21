using CIS174_TestCoreApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Filters
{
    public class ValidatePersonAttribute : ActionFilterAttribute
    {
        protected ILogger logger;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var service = (PersonService) context.HttpContext.RequestServices.GetService(typeof(PersonService));
            var personId = (int) context.ActionArguments["id"];
            if (!service.DoesPersonExist(personId))
            {
                logger.LogWarning("The person with this id does not exist. ID: {id}", personId);
                context.Result = new NotFoundResult();
            }
        }
    }
}

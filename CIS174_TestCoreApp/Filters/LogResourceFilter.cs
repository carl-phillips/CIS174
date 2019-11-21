using CIS174_TestCoreApp.Entities;
using CIS174_TestCoreApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Filters
{
    public class LogResourceFilter : Attribute, IResourceFilter, IOrderedFilter
    {
        public int Order => -1;
        public bool isEnabled { get; set; }

        private ILogger _log;

        private readonly LogContext _logContext;

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Debug.WriteLine("LOGFILTER Executed");
           
            Log log = new Log
            {
                HttpStatusCode = context.HttpContext.Response.StatusCode,
                TimeOfLog = DateTime.Now,
                RequestId = Guid.NewGuid(),
                Request = context.HttpContext.Request.Scheme,
                Response = context.HttpContext.Response.ContentType
            };

            _log.LogInformation("Http Code: " + log.HttpStatusCode + "\nTime Of Log: " + log.TimeOfLog + "\nRequestId: " + log.RequestId);

            LogContext logContext = new LogContext();
            
            logContext.Add(log);
            logContext.SaveChanges();

            context.HttpContext.Items.Add("Log", log);
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            _log.LogInformation("LOGFILTER Executing");
            Debug.WriteLine("LOGFILTER Executing");
        }
    }
}

using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace WebApiActionFilter.ActionFilter
{
    public class Filter: ActionFilterAttribute,IActionFilter
    {
        string path= @"D:\logs\log";
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            using (StreamWriter sw =File.AppendText(path))
            {
                sw.WriteLine($"{context.HttpContext.Request.Path.Value} Starting");
            }
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{context.HttpContext.Request.Path.Value} Ended");
            }
        }
    }
}

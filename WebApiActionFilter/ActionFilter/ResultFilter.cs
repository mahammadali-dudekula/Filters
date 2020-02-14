using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiActionFilter.ActionFilter
{
    public class ResultFilter:ActionFilterAttribute,IResultFilter
    {
        string path = @"D:\logs\log";
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                var ds = (ObjectResult)context.Result;
                sw.WriteLine(ds.Value);
            }
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                var ds = (ObjectResult)context.Result;
                sw.WriteLine(ds.Value);
            }
        }
    }
}

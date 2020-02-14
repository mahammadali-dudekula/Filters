using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebApiActionFilter.ActionFilter
{
    public class ExceptionFilter:Attribute,IExceptionFilter
    {
        string path = @"D:\logs\log";
         public void OnException(ExceptionContext context)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(context.Exception.Message);
                sw.WriteLine(context.Exception.StackTrace);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiActionFilter.ActionFilter;

namespace WebApiActionFilter.Controllers
{
    [Route("api/controller")]
    [ApiController]
    

    public class ValuesController : ControllerBase
    {
        [Route("myfirstfilter")]
        [HttpGet]
        [Filter]
        [ResultFilter]

        public dynamic Get()
        {
            return (new { Name="Mahammad Ali",Age=21,Post="Junior Software Devoleper"});
        }

        [Route("exception")]
        [HttpGet]
        [ExceptionFilter]
        public string GetEx()
        {
            throw new Exception("Exception Occur");
        }

        [Route("getdate")]
        [HttpGet]
        [OutputCache(Duration=5)]
        public string PredeFilter()
        {
            return DateTime.Now.ToString();
        }
       
    }
}

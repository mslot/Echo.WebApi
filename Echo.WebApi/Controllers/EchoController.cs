using System;
using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace Echo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EchoController : ControllerBase
    {
        //static int c = 0;
        [HttpGet]
        public IActionResult Get(string say)
        {
            //if (c == 0)
            //{
            //    Thread.Sleep(TimeSpan.FromMinutes(1));
            //    c++;
            //}
            if (String.IsNullOrEmpty(say))
                return Ok("hello world");
            return Ok(say);
        }
    }
}

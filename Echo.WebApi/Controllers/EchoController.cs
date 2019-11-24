using System;
using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace Echo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EchoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string say)
        {
            Thread.Sleep(20000);
            if (String.IsNullOrEmpty(say))
                return Ok("hello");
            return Ok(say);
        }
    }
}

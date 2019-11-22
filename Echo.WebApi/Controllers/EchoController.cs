using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Echo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EchoController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get(string say)
        {
            if (String.IsNullOrEmpty(say))
                return Ok("hello");
            return Ok(say);
        }
    }
}

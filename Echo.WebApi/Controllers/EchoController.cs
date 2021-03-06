﻿using System;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Echo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EchoController : ControllerBase
    {
        private readonly IOptions<Secret> _secret;
        private static DateTime timestamp;

        public EchoController(IOptions<Secret> secret)
        {
            _secret = secret;
            if (timestamp == DateTime.MinValue)
                timestamp = DateTime.Now;
        }
        [HttpGet]
        public IActionResult Get(string say)
        {
            if (String.IsNullOrEmpty(say))
                return Ok("hello what??!");
            else if (say.Equals("secret"))
            {
                return Ok($"Let me tell you a {_secret.Value.ClearText} <-- secret");
            }
            return Ok(say + " - " + timestamp);
        }
    }
}

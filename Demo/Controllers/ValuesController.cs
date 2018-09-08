using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/values")]
    public class ValuesController : Controller
    {
        public IActionResult Get()
        {
            return Ok("Hello");
        }
    }
}
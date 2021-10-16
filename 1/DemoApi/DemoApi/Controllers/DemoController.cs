using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Controllers
{
    [ApiController]
    [Route("demo")]
    public class DemoController : Controller
    {
        [HttpGet]
        public String Get()
        {
            return "Hello World";
        }
    }
}

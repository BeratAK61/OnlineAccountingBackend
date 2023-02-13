using Microsoft.AspNetCore.Mvc;
using OnlineAccountingBackend.Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingBackend.Presentation.Controllers
{
    public sealed class TestController : ApiController 
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Trabzonspor");
        }

    }
}

//sealed = baska class'larin bu class'i inheritance etmemesini saglar

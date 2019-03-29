using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using App.Domain.Abstract;

namespace App.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : Controller
    {
        private IHelloService _helloService;

        public HelloController(IHelloService helloService)
        {
            _helloService = helloService;
        }

        [HttpGet]
        async public Task<JsonResult> Get()
        {
            var Result = await _helloService.GetHelloAsync();

            return new JsonResult(Result);
        }
    }
}

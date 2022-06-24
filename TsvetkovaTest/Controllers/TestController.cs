using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TsvetkovaTest.Models;
using TsvetkovaTest.Services;

namespace TsvetkovaTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public DataInput Get()
        {
            DataService dataService = new();
            return dataService.DataInput();

        }


        [HttpPost]

        public DataInput Post()
        {
            DataService dataService = new();
            return dataService.DataInput();
        }
       
    }
}
